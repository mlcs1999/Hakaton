using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class Server
    {
        private Socket serverskiSocket;
        private List<ClientHandler> clientHandlers = new List<ClientHandler>();

        public void Start()
        {
            OtvaranjeSocketa();

            OsluskivanjeSocketa();
        }

        public void Stop()
        {
            serverskiSocket.Close();

            ZatvoriKlijentskeSokete();
        }

        #region privatne metode

        private void OtvaranjeSocketa()
        {
            serverskiSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            serverskiSocket.Bind(new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ipAdress"]),
                                 int.Parse(ConfigurationManager.AppSettings["port"])));

            serverskiSocket.Listen(10);
        }

        private void OsluskivanjeSocketa()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = serverskiSocket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket);
                    clientHandlers.Add(handler);
                    Thread nit = new Thread(handler.ObradiZahteve);
                    nit.IsBackground = true;
                    nit.Start();
                }
            }
            catch (IOException e)
            {
                serverskiSocket.Close();
            }
            catch (SocketException e)
            {
                serverskiSocket.Close();
            }
            finally
            {
                ZatvoriKlijentskeSokete();
            }
        }
        private void ZatvoriKlijentskeSokete()
        {
            foreach (ClientHandler c in clientHandlers)
            {
                c.klijentskiSoket.Close();
            }
            clientHandlers.Clear();
        }
        #endregion
    }
}
