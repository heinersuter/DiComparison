using System;
using Autofac;
using Library;

namespace AutoFacTest
{
    public class Program
    {
        public static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Parent>().As<IParent>().SingleInstance(); // Parent via Interface als Singleton
            builder.RegisterType<Child>(); // Child ohne Interface
            var container = builder.Build();

            var parent = container.Resolve<IParent>(new TypedParameter(typeof(string), "Autofac")); // Resolve mit zusätzlichem Parameter
            Console.WriteLine(parent.Child.Content);
            parent = container.Resolve<IParent>(new NamedParameter("x", "Autofac 2")); // Zweiter parameter wird ignoriert
            Console.WriteLine(parent.Child.Content);

            Console.ReadKey();
        }
    }
}
