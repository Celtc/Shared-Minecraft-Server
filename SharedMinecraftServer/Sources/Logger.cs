using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using SharedMinecraftServer.Utils;

namespace SharedMinecraftServer.Sources
{
    public class Logger
    {
        //Variables
        private string pathLog = null;
        private FileStream logFile = null;
        private bool logFileLoaded;
        
        //Builder
        public Logger()
        {
            //Inicializa
            this.pathLog = ".\\";
            this.logFileLoaded = false;
        }

        //Carga el archivo donde se almacenaran los logs
        public bool LoadLogFile()
        {
            try
            {
                //Abre
                this.logFile = new FileStream(pathLog + logName(), FileMode.Append, FileAccess.Write);

                //Encabezado de sesion
                string logLine = System.String.Format("{0:G}: Log abierto, fecha [{1}/{2}/{3}]. Preparando ejecución.\n", System.DateTime.Now, DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
                Auxiliar.AddText(this.logFile, logLine);
                this.logFile.Flush(true);
            }
            catch
            {
                Errno.code = 4;
                Errno.msg = "Error de I/O en logs.";
                return false;
            }

            return (logFileLoaded = true);
        }

        //Libera el archivo donde se almacenaran los logs
        public bool UnloadLogFile()
        {
            if (logFileLoaded)
            {
                try
                {
                    //Pie
                    string logLine = System.String.Format("{0:G}: Cerrando log.\n\n", System.DateTime.Now);
                    Auxiliar.AddText(this.logFile, logLine);

                    //Cierra
                    this.logFile.Close();
                    this.logFile.Dispose();
                }
                catch
                {
                    Errno.code = 5;
                    Errno.msg = "Error de I/O en logs.";
                    return false;
                }
            }

            return true;
        }

        //Método que devuelve el nombre del log a guardar en esta sesión
        private string logName()
        {
            return string.Empty + "log_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + ".log";
        }

        //Método para logear mensages
        public void Log(string msg)
        {
            try
            {
                string logLine = System.String.Format("{0:G}: INFO: {1}.\n", System.DateTime.Now, msg);
                Auxiliar.AddText(logFile, logLine);
            }
            catch
            {
            }
        }

        //Método para logear mensages de error
        public void LogError(string msg)
        {
            try
            {
                string logLine = System.String.Format("{0:G}: ERROR: {1}.\n", System.DateTime.Now, msg);
                Auxiliar.AddText(logFile, logLine);
            }
            catch
            {
            }
        }
    }
}
