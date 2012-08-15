using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using SharedMinecraftServer.Sources;

namespace SharedMinecraftServer.Utils
{
    public static class Configuration
    {
        //Variables globales de configuración
        public static string user = null;
        public static string port = null;

        //Desencripta el archivo de configuracion y lo aloja en memoria
        public static bool ReadConfigFile()
        {
            //Variables locales
            string filename = "config.ini";

            //Verifica la existencia del archivo
            if (!File.Exists(filename)) try
                {
                    FileStream createdFile = File.Create(filename);

                    Auxiliar.AddText(createdFile, "User=default\n");
                    Auxiliar.AddText(createdFile, "Port=5666\n");
                    Auxiliar.AddText(createdFile, "[END]");

                    createdFile.Close();
                    createdFile.Dispose();
                }
                catch
                {
                    //Error
                    Errno.code = 1;
                    Errno.msg = "Imposible crear el archivo (¿faltan permisos?)";
                    return false;
                }

            //Lo abre
            using (FileStream configurationFile = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                //Abre el archivo
                try
                {
                    //Variable local
                    System.Text.StringBuilder SBuilder = new System.Text.StringBuilder("");

                    //Buffer de lectura
                    byte[] data = new byte[4096];
                    Auxiliar.DataSet(ref data, 0, 4096);

                    //Lee hasta que no haya mas que leer
                    Int32 sizeRead = 0;
                    while ((sizeRead = configurationFile.Read(data, 0, 4096)) > 0)
                    {
                        SBuilder.Append(System.Text.Encoding.ASCII.GetString(data), 0, sizeRead);
                    }
                    SBuilder.AppendLine();

                    //Verifica que haya leido algo
                    if (SBuilder.Length == 0)
                    {
                        //Error
                        Errno.code = 2;
                        Errno.msg = "Archivo de configuración vacio";
                        return false;
                    }

                    //Lo parsea
                    string dataString = SBuilder.ToString();
                    string dataLine = null;

                    while ((dataLine = Auxiliar.extractLine(ref dataString)) != null)
                    {
                        if (dataLine.Contains("User"))
                        {
                            user = dataLine.Substring(5);
                        }
                        else if (dataLine.Contains("Port"))
                        {
                            port = dataLine.Substring(5);
                        }
                    }
                }
                catch
                {
                    //Error
                    Errno.code = 3;
                    Errno.msg = "Archivo de configuración inválido";
                    return false;
                }
            }

            return true;
        }

        //Guarda los cambios en el archivo de configuracion
        public static bool SaveConfigFile()
        {
            //Variables locales
            string filename = "config.ini";

            //Lo abre
            using (FileStream configurationFile = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
            {
                try
                {
                    Auxiliar.AddText(configurationFile, "User=" + user + "\n");
                    Auxiliar.AddText(configurationFile, "Port=" + port + "\n");
                    Auxiliar.AddText(configurationFile, "[END]");

                    configurationFile.Close();
                    configurationFile.Dispose();
                }
                catch
                {
                    //Error
                    Errno.code = 1;
                    Errno.msg = "Imposible modificar el archivo (¿faltan permisos?)";
                    return false;
                }
            }

            return true;
        }
    }
}
