using System;
using Library;
using SimpleInjector;

namespace SimpleInjectorTest
{
    public class Program
    {
        public static void Main()
        {
            var container = new Container();

            var parent = new Parent(container.GetInstance<Child>(), "SimpleInjector");
            Console.WriteLine(parent.Child.Content);

            Console.ReadKey();
        }
    }
}
