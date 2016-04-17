using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace chatroomServer
{
    public partial class Form1 : Form
    {
        TcpListener tcplistener;
        string servaddress;
        int port;
        bool isListening = false;
        bool isAnonymousChecked = false;
        bool isExit = false;
        TcpClient tcpclient;
        NetworkStream networkstream;
        BinaryReader binaryreader;
        BinaryWriter binarywriter;
        List<UserClient> userLists = new List<UserClient>();

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            int i = 0;
            foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                chatRecordList.Items.Add("[Tips]:本机IP地址:" + Dns.GetHostAddresses(Dns.GetHostName())[i]);
                i++;
            }

        }

        /// <summary>
        /// 启动服务
        /// </summary>
        private void startServer()
        {
            try
            {
                servaddress = servAddress.Text;
                port = Convert.ToInt32(servPort.Text);
                tcplistener = new TcpListener(IPAddress.Parse(servaddress), port);
                tcplistener.Start();
                chatRecordList.Items.Add("[Tips]:服务器在" + servaddress + ":" + port.ToString() + "上开始监听");
                servStartListener.Enabled = false;
                isListening = true;
            }
            catch
            {
                MessageBox.Show("IP地址和端口设置有误");

            }
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        private void stopServer()
        {
            servStartListener.Enabled = true;
            tcpclient.Close();
            tcplistener.Stop();
            networkstream.Close();
            chatRecordList.Items.Add("[Tips]:服务器在" + servaddress + ":" + port.ToString() + "上停止监听");
            isListening = false;
        }

        private void newClientThreadMethod()
        {
            while (!isExit)
            {
                tcpclient = tcplistener.AcceptTcpClient();
                UserClient userclient = new UserClient(tcpclient);
                Thread userClientThread = new Thread(newUserClientThreadMethod);
                userClientThread.Start(userclient);
            }

        }

        public void sendUserLists()
        {
            string userListStr = "userlist";
            foreach (UserClient user in userLists)
            {
                userListStr = userListStr + "," + user.userName;
                //userListStr.Insert(userListStr.Length - 1, "," + user.userName);
            }
            foreach (UserClient user in userLists)
            {
                user.binarywriter.Write(userListStr);
                user.binarywriter.Flush();
            }
        }

        private void newUserClientThreadMethod(Object ouserclient)
        {
            UserClient userclient = (UserClient)ouserclient;
            while (true)
            {
                try
                {
                    string userReaderStr = userclient.binaryreader.ReadString();
                    string[] splitedStrs = userReaderStr.Split(',');
                    switch (splitedStrs[0])
                    {
                        case "message":
                            chatRecordList.Items.Add("[" + splitedStrs[1] + "]对[" + splitedStrs[2] + "]说:" + splitedStrs[3]);
                            foreach (UserClient user in userLists)
                            {
                                if (splitedStrs[2] == user.userName)
                                {
                                    user.binarywriter.Write(userReaderStr);
                                    user.binarywriter.Flush();
                                }
                            }
                            break;
                        case "connect":
                            userclient.userName = splitedStrs[1];
                            userLists.Add(userclient);
                            userList.Items.Add(splitedStrs[1]);
                            chatRecordList.Items.Add("[Tips]:" + splitedStrs[1] + " 已加入聊天");
                            sendUserLists();
                            break;
                        case "bye":
                            string tempStr = "";
                            foreach (UserClient user in userLists)
                            {
                                if (user.userName == splitedStrs[1])
                                {
                                    tempStr = "[Tips]: " + user.userName + "已退出聊天";
                                    chatRecordList.Items.Add(tempStr);
                                    userLists.Remove(user);
                                    sendUserLists();
                                    userList.Items.Remove(user.userName);
                                    break;
                                }
                            }


                            break;
                    }
                }
                catch
                {
                    return;
                }



            }


        }


        private void servStartListener_Click(object sender, EventArgs e)
        {
            startServer();
            Thread newClientThread = new Thread(new ThreadStart(newClientThreadMethod));
            newClientThread.Start();
        }

        private void servStopListener_Click(object sender, EventArgs e)
        {
            stopServer();
        }

        private void isAnonymous_Click(object sender, EventArgs e)
        {
            if (isAnonymousChecked)
            {
                isAnonymous.Checked = false;
                isAnonymousChecked = false;
            }
            else
            {
                isAnonymous.Checked = true;
                isAnonymousChecked = true;
            }
        }

        private void sendMessageBtn_Click(object sender, EventArgs e)
        {
            string text = sendText.Text;
            try
            {
                string targetUser = userList.SelectedItem.ToString();
                //binarywriter = new BinaryWriter(networkstream);
                foreach (UserClient user in userLists)
                {
                    if (targetUser == user.userName)
                    {
                        user.binarywriter.Write("message,Server," + targetUser + "," + text);
                        user.binarywriter.Flush();
                        chatRecordList.Items.Add("[Server]对[" + targetUser + "]说:" + text);
                    }

                }

            }
            catch
            {
                MessageBox.Show("请选择用户");
            }


        }

        private void sendToAllBtn_Click(object sender, EventArgs e)
        {
            string text = sendText.Text;
            try
            {

                //binarywriter = new BinaryWriter(networkstream);
                foreach (UserClient user in userLists)
                {
                    user.binarywriter.Write("message,Server,All," + text);
                    user.binarywriter.Flush();
                    chatRecordList.Items.Add("[Server]对[All]说:" + text);
                }

            }
            catch
            {
                MessageBox.Show("请选择用户");
            }
        }

        private void kickout_Click(object sender, EventArgs e)
        {
            foreach (UserClient user in userLists)
            {
                if (user.userName == userList.SelectedItem.ToString())
                {
                    user.binarywriter.Write("kickout");
                    user.binarywriter.Flush();
                    chatRecordList.Items.Add("[Tips]: " + user.userName + " 已被踢出");
                    break;
                }
            }
        }
    }
}
