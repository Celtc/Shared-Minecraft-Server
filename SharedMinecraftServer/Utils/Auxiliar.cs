using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using SharedMinecraftServer.Sources;

namespace SharedMinecraftServer.Utils
{
    public static class Auxiliar
    {
        public static void DataSet(ref byte[] data, byte fillwith, UInt32 dataSize)
        {
            for(int i = 0; i < dataSize; i++)
            {
                data[i] = fillwith;
            }

            return;
        }

        public static void AddText(FileStream fileStream, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);

            fileStream.Write(info, 0, info.Length);

            return;
        }

        public static string generateBoundary()
        {
            string sBoundary = Guid.NewGuid().ToString();

            sBoundary = sBoundary.Replace("-", string.Empty);
            sBoundary = sBoundary.Substring(0, 16);

            return sBoundary;
        }

        public static string extractLine(ref string lines)
        {
            if (lines.Length == 0)
                return null;

            string result = null;
            char[] flags = {'\0', '\n', '\r'};
            int lineEnd = 0;

            lineEnd = lines.IndexOfAny(flags);
            result = lines.Substring(0, lineEnd);
            lines = lines.Substring(lineEnd + 1);

            return result.Length == 0?null:result;
        }
    }
}
