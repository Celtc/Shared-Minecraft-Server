using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SharedMinecraftServer;
using SharedMinecraftServer.Utils;
using System.Threading;

namespace SharedMinecraftServer.Sources
{
    public class Connection
    {
        //Usuario que se gestiona
        public User user { set; get; }        

        //Builder
        public Connection(User user)
        {
            this.user = user;
            user.Online = true;
        }

        //Loop principal de control
        public void MainMethod()
        {
            //Variable local
            bool retValue;

            while (true)
            {
                try
                {
                    //Pregunta si es dueño de un server
                    retValue = ServerQuestion();
                    if (retValue)
                    {
                        //Es dueño de un server
                        user.ServerOwner = true;
                    }
                    else
                    {
                        user.ServerOwner = false;
                    }
                }
                catch
                {
                    //Desconexion

                }

                //Pequeño sleep
                Thread.Sleep(2000);
            }
        }

        //Pregunta al usuario si es dueño de un server.
        //Puede devolver true (es dueño), false (no es dueño) o una excepcion en caso de desconexión.
        private bool ServerQuestion()
        {


            return false;
        }
    }
}
