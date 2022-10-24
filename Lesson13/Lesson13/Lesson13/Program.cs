using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stream // Замый главный стример
            //MemoryStream; // запись данных в оперативную память
            //BinaryFormatter; //xyna
            //XmlSerializer // top

            var obj = new Person()
            {
                Age = 12,
                Street = new Adress()
            };

            FileStream stream = File.Open("person.json", FileMode.OpenOrCreate);
            var sw = new StreamWriter(stream);

            JsonSerializer js = new JsonSerializer();
            js.Serialize(sw, obj);
            sw.Flush();

            var temp = JsonConvert.SerializeObject(obj);
            var deObg = JsonConvert.DeserializeObject<Person>(temp);
            Console.WriteLine(deObg);

            stream.Seek(0, SeekOrigin.Begin);
            
            var streamReader = new StreamReader(stream);
            Console.WriteLine(streamReader.ReadToEnd());

            var deserializableObj = (Person)js.Deserialize(streamReader, typeof(Person));
            Console.WriteLine(deserializableObj);
            stream.Close();









            #region XML
            ////Create serializeble
            ////DataContractJsonSerializer()// for security person
            //XmlSerializer xs = new XmlSerializer(typeof(Person));

            //xs.Serialize(stream, obj);
            //stream.Seek(0, SeekOrigin.Begin);

            //var streamReader = new StreamReader(stream);
            //Console.WriteLine(streamReader.ReadToEnd());

            //stream.Seek(0 , SeekOrigin.Begin);

            //var deserializedobj = (Person)xs.Deserialize(stream);
            //Console.WriteLine(deserializedobj);
            //stream.Close();
            #endregion





            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, obj);

            var personFromFile = (Person)bf.Deserialize(stream);
            stream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(personFromFile);
            stream.Close();


            var streamWriter = new StreamWriter(stream);
            streamWriter.Write(obj);
            streamWriter.Flush();








            #region for cool boys
            //var streamWriter = new StreamWriter(stream);
            //streamWriter.Write(str);
            //stream.Flush();


            //var streamReader = new StreamReader(stream);
            //var someText = streamReader.ReadToEnd();
            #endregion

            #region for down
            //byte[] systesToRad = Encoding.Unicode.GetBytes(str);
            //stream.Write(systesToRad);
            //stream.Flush();
            //stream.Seek(0 , SeekOrigin.Begin); // 0 это сдвиг после установления позиции SeekOrigin.Begin

            //var buffer = new byte[2];
            //var bytesRead = 1;
            //var neString = "";
            //while(bytesRead > 0) // мы ебашим пока не устанем
            //{
            //    bytesRead = stream.Read(buffer, 0, 2);
            //    neString += Encoding.Unicode.GetString(buffer);
            //}
            //Console.WriteLine($"{stream.Position} {stream.Length} {neString}");

            //stream.Close();
            #endregion
        }
    }
    [Serializable]
    public class Person
    {
        public int Age { get; set; }
        private string _name;
        public Adress Street { get; set; }
        public Person()
        {
            _name = "Nick";
            

        }
        public override string ToString()
        {
            return $"{Age} {_name}";
        }
    }
    public class Adress
    {
        public string Street { get; set; }
    }
}
