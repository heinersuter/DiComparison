using System;
using Library;
using LightInject;

namespace LightInjectTest
{
    public class Program
    {
        public static void Main()
        {
            var container = new ServiceContainer();
            container.Register<Child>();
            container.Register<string, IParent>((factory, arg) => new Parent(factory.GetInstance<Child>(), arg)); // Construktor mit dynamischer Parameter muss explizit aufgerufen werden

            var parent = container.GetInstance<string, IParent>("LightInject");
            Console.WriteLine(parent.Child.Content);
            parent = container.GetInstance<string, IParent>("LightInject 2");
            Console.WriteLine(parent.Child.Content);

            Console.ReadKey();
        }
    }
}
