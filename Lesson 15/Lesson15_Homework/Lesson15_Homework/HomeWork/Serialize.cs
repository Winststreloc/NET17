using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace MyBestProj.HomeWork
{
    public class Serialize
    {
        public static void StartSerialize()
        {
            var first = new Transformer("Egor", 123, new Gun("Pistolet", 1.2, 7));
            var second = new Transformer("Anton", 1234, new Gun());
            var third = new Transformer("third", 635, new Gun());
            var fo = new Transformer("Ighar", 223, new Gun());
            var five = new Transformer("Vlad", 001, new Gun("Pistolet", 1.2, 7));
            List<Transformer> items = new List<Transformer> { first, second, third, fo, five };

            FileStream stream = File.Open(Ui.Path, FileMode.OpenOrCreate);
            var sw = new StreamWriter(stream);

            JsonSerializer js = new JsonSerializer();
            js.Serialize(sw, items);
            sw.Flush();
            stream.Close();
        }
        public static void EndSerialize()
        {
            FileStream stream = File.Open(Ui.Path, FileMode.OpenOrCreate);
            var sw = new StreamWriter(stream);

            JsonSerializer js = new JsonSerializer();
            js.Serialize(sw, Ui.List);
            sw.Flush();
            stream.Close();
        }

    }
}
