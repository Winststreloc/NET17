using Lesson10_libtary;
using System;
using System.Reflection;

namespace Lessson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 someClass = new Class1();
            Type someType = someClass.GetType();
            MemberInfo[] interfaces = someType.GetInterfaces();
            
            foreach(var @interface in interfaces)
            {
                Console.WriteLine(@interface);
            }
            someClass.Name = "Name";
        }
    }
}
