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
using System.IO;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace chatroomClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        TcpClient tcpclient;
        
        string address;
        int port;
        string loginName;
        NetworkStream networkstream;
        BinaryReader binaryreader;
        BinaryWriter binarywriter;
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                address = servAddress.Text;
                port = Convert.ToInt32(servPort.Text);
                loginName = userName.Text;
                if (loginName.Equals(null) || loginName.Equals(""))
                {
                    MessageBox.Show("登录名不能为空!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tcpclient = new TcpClient(address, port);
                    //usermessage = new UserMessage();
                    //usermessage.type = UserMessage.Type.Connect;
                    //usermessage.name = loginName;
                    //BinaryFormatter binaryformatter = new BinaryFormatter();
                    //binaryformatter.Serialize(networkstream, usermessage);
                    networkstream = tcpclient.GetStream();
                    binarywriter = new BinaryWriter(networkstream);
                    binarywriter.Write("connect," + loginName);
                    binarywriter.Flush();
                    networkstream.Flush();
                    Thread newthread = new Thread(new ThreadStart(newClientThread));
                    newthread.Start();
                }

            }
            catch
            {
                chatList.Items.Add("[Tips]:连接服务器失败,请检查设置");
            }

        }

        private string packageStr(string type,  string from, string to, string message)
        {
            return type + ","  + from + "," + to + "," + message;
        }

        private void newClientThread()
        {
            networkstream = tcpclient.GetStream();
            binaryreader = new BinaryReader(networkstream);
            chatList.Items.Add("[Tips]:连接服务器成功");
            while (true)
            {

                string recvStr = binaryreader.ReadString();
                parseRecvStr(recvStr);

            }

        }

        private void parseRecvStr(string recvStr)
        {
            string[] splitedStrs = recvStr.Split(',');
            switch (splitedStrs[0])
            {
                case "connect":

                    break;
                case "message":
                    chatList.Items.Add("[" + splitedStrs[1] + "]对[" + splitedStrs[2] + "]说:" + recvStr.Substring(splitedStrs[0].Length+splitedStrs[1].Length+splitedStrs[2].Length+3));
                    break;
                case "userlist":
                    userList.Items.Clear();
                    foreach(string splitedStr in splitedStrs)
                    {
                        if (splitedStr == "userlist")
                        {

                        }
                        else
                        {
                            
                            userList.Items.Add(splitedStr);
                        }
                        
                    }
                
                    break;
                case "kickout":
                    MessageBox.Show("你已被服务器踢出聊天!", "来自服务器的消息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    break;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            sendText.Clear();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            //tcpclient = new TcpClient(address, port);

            //networkstream = tcpclient.GetStream();
            //binarywriter = new BinaryWriter(networkstream);
            try
            {
                binarywriter.Write(packageStr("message", loginName, userList.SelectedItem.ToString(), sendText.Text));
                binarywriter.Flush();
                networkstream.Flush();
                chatList.Items.Add("[" + loginName + "]对[" + userList.SelectedItem.ToString() + "]说:" + sendText.Text);
            }
            catch
            {
                MessageBox.Show("选择一个接收方");
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loginName != null)
            {
                binarywriter.Write("bye," + loginName);
            }
            binaryreader.Close();
            binarywriter.Close();
            networkstream.Close();
            tcpclient.Close();
            
        }
    }
}
