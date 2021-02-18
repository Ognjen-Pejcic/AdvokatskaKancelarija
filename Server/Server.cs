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
        static List<ClientHandler> clienthandlers = new List<ClientHandler>();
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
                    clienthandlers.Add(handler);
                    Thread nit = new Thread(handler.ObradiZahteve);
                    nit.IsBackground=true;
                    nit.Start();
                }
            }
            catch
            {

            }
     }

        internal void Stop()
        {
            serverskiSocket.Close();
            ClientHandler.logovaniSekretari.Clear();
            foreach (ClientHandler c in clienthandlers)
            {
                
                c.klijentskiSoket.Close();
            }
            
            clienthandlers.Clear();

        }

    }
    
}