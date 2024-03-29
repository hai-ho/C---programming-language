﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Multisend
{
    class Program
    {
        public static void Main(string[] args)
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("224.100.0.1"), 9050);

            byte[] data = Encoding.ASCII.GetBytes("This is a test message");
            server.SendTo(data, iep);
            server.Close();
        }
    }
}
