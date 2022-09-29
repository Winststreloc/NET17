using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
                    var a = new A();
            int? someData = a?.SomeObjProp?.SomeData ?? "if null";
            var c = someData + 2;

            var a = new A();
            var b = new B();

            var c = A + B;
        }

    }

    public class A
    {
        public B SomeObjProp { get; set;}
    }

    public class B
    {
        public string SomeData { get; set;}
    }
}
