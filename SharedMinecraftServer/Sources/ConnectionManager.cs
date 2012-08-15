using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

using SharedMinecraftServer;
using SharedMinecraftServer.Utils;
using System.Threading;

namespace SharedMinecraftServer.Sources
{
    public class ConnectionManager
    {
        //Variables
        public List<User> Users;

        //Builder
        public ConnectionManager()
        {
            this.Users = new List<User>();
        }

        //Funcion inicial
        public void MainMethod()
        {
            //Loop de conexion
            while (true)
            {
                //Intenta conectar a todos los usuarios
                foreach (User user in Users)
                {
                    //Si ya no esta conectado o online
                    if (!user.Online)
                    {
                        try
                        {
                            user.Socket = Network.Connect(user.IP, int.Parse(user.Port));
                        }
                        catch
                        {
                            //nothing
                        }

                        //Conecto a un usuario
                        if (user.Socket != null)
                        {
                            try
                            {
                                //Levanta un hilo para gestionar el usuario
                                Connection _connection = new Connection(user);
                                Thread _connectionThread = new Thread(new ThreadStart(_connection.MainMethod));
                                _connectionThread.Start();
                            }
                            catch
                            {
                                //Error
                                Errno.code = 13;
                                Errno.msg = "No se pudieron crear los hilos de procesamiento";
                                AppWindow.logger.LogError(Errno.msg);
                            }
                        }
                        
                        //Pequeño sleep
                        Thread.Sleep(500);
                    }
                }
            }

            return;
        }

        #region Client

        //Función encargada de conectar


        #endregion

        #region Server
        #endregion
    }
}
