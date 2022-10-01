using System;

namespace Lesson11
{
    delegate void SomeMethodDelegate(); //Action
    delegate void SomeMethodDelegate(int a); //Action<int>

    delegate int SomeMethodDelegate(); //Function<int>
    delegate int SomeMethodDelegate(string a); //Function <string, int>

    delegate bool SomeMethodDelegate(int a, int b) //Predicate<int, int>

    class Program
    {
        static void Main(string[] args)
        {




            #region
            //var obj = new SomeClass();

            //var attributes = obj.GetType().GetCustomAttributes(false);
            //bool attrExists = false;

            //foreach (var att in attributes)
            //{
            //    if (att is VersionAttribute versionAttribute)
            //    {
            //        attrExists = true;
            //        versionAttribute.Version = 3;
            //    }
            //}
            #endregion

        }
        static void PrintParameters(Action<int> param)
        {
            param()
        }
    }
    [Version(2, Author = "Some Author")]
    public class SomeClass
    {

    }
}
