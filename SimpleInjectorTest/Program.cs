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
            //container.Register<IParent, Parent>(); // Fails because sing parameter cannot be injected
            // No need to register child

            var parent = new Parent(container.GetInstance<Child>(), "SimpleInjector"); // Not possible to provide a parameter
            Console.WriteLine(parent.Child.Content);
            //var parent2 = container.GetInstance<IParent>();
            //Console.WriteLine(parent2.Child.Content);

            Console.ReadKey();
        }
    }
}
