using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

using SharedMinecraftServer.Utils;
using System.Threading;

namespace SharedMinecraftServer.Sources
{
    public class User
    {
        //Variables públicas
        public Socket Socket { set; get; }
        public string IP { set; get; }
        public string Port { set; get; }
        public string Name { set; get; }
        public bool ServerOwner { set; get; }
        public bool Online { set; get; }

        //Builder
        public User()
        {
            this.IP = string.Empty;
            this.Port = string.Empty;
            this.Name = string.Empty;
            this.Online = false;
            this.ServerOwner = false;
            this.Socket = null;
        }
    }
}
