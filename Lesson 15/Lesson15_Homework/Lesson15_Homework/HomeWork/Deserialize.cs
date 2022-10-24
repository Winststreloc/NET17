using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MyBestProj.HomeWork
{
    public class Deserialize
    {
        public static List<Transformer> ReadingFile(string path)
        {

            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                StreamReader streamReader = new StreamReader(fs);
                JsonSerializer json = new JsonSerializer();

                var array = (List<Transformer>)json.Deserialize(streamReader, typeof(List<Transformer>));

                fs.Close();  
                return array;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Ui.Start();
            }

            return null;
        }
    }
}
