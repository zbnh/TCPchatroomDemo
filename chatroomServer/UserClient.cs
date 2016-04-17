using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace chatroomServer
{
    class UserClient
    {
        TcpClient tcpclient;
        public string ipaddress { get; set; }
        public int port { get; set; }
        public string userName { get; set; }
        public BinaryReader binaryreader;
        public BinaryWriter binarywriter;


        public UserClient(TcpClient client)
        {
            tcpclient = client;
            binaryreader = new BinaryReader(tcpclient.GetStream());
            binarywriter = new BinaryWriter(tcpclient.GetStream());
        }
    }
}
