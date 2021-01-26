using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
            private Socket serverskiSocket;
            
            public Server()
            {
                
            }

            public void Start()
            {
            serverskiSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverskiSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000));
            serverskiSocket.Listen(10);
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = serverskiSocket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket);
                    Thread nit = new Thread(handler.ObradiZahteve);
                    nit.IsBackground=true;
                    nit.Start();
                }
            }
            catch
            {

            }
     }

       

            //internal void Stop()
            //{
            //    serverskiSocket.Close();
            //    foreach (ClientHandler c in clients)
            //    {
            //        // c.Stop();
            //    }
            //    clients.Clear();
            //}
    }
    
}