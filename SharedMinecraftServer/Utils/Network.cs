using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;

using SharedMinecraftServer.Sources;

namespace SharedMinecraftServer.Utils
{
    public static class Network
    {
        //Función encargada de obtener la IP externa de una computadora
        public static string GetExternalIP()
        {
            //Manda el pedido
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create("http://www.whatismyip.org/");
            request.UserAgent = "User-Agent: Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1,1,4322; .NET CLR 2.0.50727)";

            //Recibe la rta
            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            string myExternalIP = string.Empty;

            //La interpreta
            using (System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream()))
            {
                myExternalIP = reader.ReadToEnd();
                reader.Close();
            }
            response.Close();

            return myExternalIP;
        }


        //Función utilizada para conectar a un servidor o algun escucha
        public static Socket Connect(string hostname, int port)
        {
            TcpClient client = new TcpClient(hostname, port);
            Socket socket = client.Client;
            if (!socket.Connected)
            {
                return null;
            }
            else
                return socket;
        }

        //Función encargada de mandar un paquete
        public static void Send(Socket socket, byte[] buffer, int offset, int size, int timeout)
        {
            //Variables locales
            int startTickCount = Environment.TickCount;
            int dataSent = 0;

            do
            {
                if (Environment.TickCount > startTickCount + timeout)
                    throw new Exception("Timeout.");
                try
                {
                    dataSent += socket.Send(buffer, offset + dataSent, size - dataSent, SocketFlags.None);
                }
                catch (SocketException ex)
                {
                    if (ex.SocketErrorCode == SocketError.WouldBlock ||
                       ex.SocketErrorCode == SocketError.IOPending ||
                       ex.SocketErrorCode == SocketError.NoBufferSpaceAvailable)
                    {
                        Thread.Sleep(30);
                    }
                    else
                        throw ex;
                }
            } while (dataSent < size);
        }

    }
}
