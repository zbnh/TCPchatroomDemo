using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chatroomClient
{
    [Serializable]
    class UserMessage
    {
        public enum Type { Connect,Message}
        public Type type { get; set; }
        public string IPaddress { get; set; }
        public string port { get; set; }
        public string from { get; set; }
        public string sendTo { get; set; }
        public string message { get; set; }
        public string name { get; set; }
    }
}
