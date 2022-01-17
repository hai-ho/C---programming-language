using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace broadcast
{
    class Program
    {
        public static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep1 = new IPEndPoint(IPAddress.Broadcast, 9050);
            IPEndPoint iep2 = new IPEndPoint(IPAddress.Parse("192.168.1.255"), 9050);

            string hostname = Dns.GetHostName();
            byte[] data = Encoding.ASCII.GetBytes(hostname);

            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            sock.SendTo(data, iep1);
            sock.SendTo(data, iep2);
            sock.Close();
        }
    }
}
