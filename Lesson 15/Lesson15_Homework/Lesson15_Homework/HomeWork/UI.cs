using System;
using System.Collections.Generic;

namespace MyBestProj.HomeWork
{
    public class Ui
    {
        public static string Path { get; set; }
        public static List<Transformer> ObjForPrint { get; set; }
        public static Table<string, int, Gun> List = new Table<string, int, Gun>();
        public static void Start()
        {
            Path = AddPathForDeserialize();

            FileLogger fileLogger = new FileLogger("logger.json");
            List.AddInList += fileLogger.WriteLog;
            List.RemoveInList += fileLogger.WriteLog;

            Serialize.StartSerialize();

            ObjForPrint = Deserialize.ReadingFile(Path);

            if (ObjForPrint != null)
            {
                foreach (var item in ObjForPrint)
                {
                    List.Add(item.Name, item.Id, item.Gun);
                }
            }
            else
            {
                throw new ArgumentNullException("Ex");
            }
        }

        public static void WorkApp()
        {
            //AddParamInList();//User can add new line in table
            List.Add("asda", 332, new Gun()); //ADD
            List.Add("1123123", 23, new Gun());
            List.Add("23123123", 23, new Gun());
            List.Add("asda", 332, new Gun());
            List.Add("asda", 332, new Gun());
            List.Add("1123123", 23, new Gun());
            List.Add("23123123", 23, new Gun());
            List.Remove(2); // DELETE
            List.Print();
            Serialize.EndSerialize();

            Pagination();

        }
        public static void Pagination()
        {
            while (true)
            {
                string choice = Console.ReadLine();
                if (choice == "next")
                {
                    if (List.PageNumber < List.TotalPages)
                        List.PageNumber++;
                    Console.Clear();
                    List.Print();
                }
                else if (choice == "back")
                {
                    if (List.PageNumber > 0)
                    {
                        List.PageNumber--;
                        Console.Clear();
                        List.Print();
                    }
                }
            }
        }

        public static string AddPathForDeserialize()
        {
            Console.WriteLine("Enter path for print table?");
            return Console.ReadLine();
        }
        public static void AddParamInList()
        {
            Console.WriteLine("Enter param Add");
            var firstParam = Console.ReadLine();
            var secondParam = int.Parse(Console.ReadLine() ?? string.Empty);
            var thirdParam = Gun.CreateGun();
            List.Add(firstParam, secondParam, thirdParam);
        }

    }
}
