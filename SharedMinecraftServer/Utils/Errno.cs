using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SharedMinecraftServer.Sources;

namespace SharedMinecraftServer.Utils
{
    public static class Errno
    {
        //Código de error
        private static Int16 _code;
        public static Int16 code
        {
            set { _code = value; }
            get { return _code; }
        }

        //Mensage de error
        private static string _msg;
        public static string msg
        {
            set { _msg = value; }
            get { return _msg; }
        }
    }
}
