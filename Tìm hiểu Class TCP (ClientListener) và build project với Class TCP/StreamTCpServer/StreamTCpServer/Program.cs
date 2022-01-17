﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace StreamTCpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);

            Socket newsock = new Socket(AddressFamily.InterNetwork,
                            SocketType.Stream, ProtocolType.Tcp);

            newsock.Bind(ipep);
            newsock.Listen(10);
            Console.WriteLine("Waiting for a client...");

            Socket client = newsock.Accept();
            IPEndPoint newclient = (IPEndPoint)client.RemoteEndPoint;
            Console.WriteLine("Connected with {0} at port {1}",
                            newclient.Address, newclient.Port);

            NetworkStream ns = new NetworkStream(client);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            string welcome = "Welcome to my test server";
            sw.WriteLine(welcome);
            sw.Flush();

            while (true)
            {
                try
                {
                    data = sr.ReadLine();
                }
                catch (IOException)
                {
                    break;
                }

                Console.WriteLine(data);
                sw.WriteLine(data);
                sw.Flush();
            }
            Console.WriteLine("Disconnected from {0}", newclient.Address);
            sw.Close();
            sr.Close();
            ns.Close();
        }
    }
}
