using Newtonsoft.Json;
using System;
using System.IO;

namespace MyBestProj.HomeWork
{
    public class FileLogger : ILogger
    {
        private string filePath;
        public FileLogger(string path)
        {
            filePath = path;
        }

        public void WriteLog(Line<string, int, Gun> strValue, string action)
        {
            FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);
            string path = "log.json";
            StreamWriter sw = new StreamWriter(stream);
            try
            {
                if (!File.Exists(path))
                { sw = File.CreateText(path); }
                else
                { sw = File.AppendText(path); }

                SerializeLog(strValue, action, sw);

                sw.Flush();
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                stream.Close();
            }
            
        }
        private static void SerializeLog(Line<string, int, Gun> logMessage, string action, StreamWriter sw)
        {
            JsonSerializer js = new JsonSerializer();
            js.Serialize(sw, $"User {action} --- " + logMessage + DateTime.Now);
            sw.Flush();
        }
    }
}
