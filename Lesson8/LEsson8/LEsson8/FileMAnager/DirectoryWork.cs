using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Linq;

namespace Lesson8.FileMAnager
{
    public class DirectoryWork
    {
        private static readonly List<Type> typeList = new List<Type>();

        public static List<Type> ReBuilding()
        {
            Assembly asmbly = Assembly.GetExecutingAssembly();
            var files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*dll");
            foreach (var file in files)
            {
                try
                {
                    asmbly.GetTypes().Where(
                        t => t.GetInterface("IPrintable") != null).ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return typeList;
        }
    }
}
