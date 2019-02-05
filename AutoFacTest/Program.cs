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
            builder.RegisterType<Parent>().As<IParent>().SingleInstance(); // Parent by Interface as Singleton
            builder.RegisterType<Child>(); // Child without Interface
            var container = builder.Build();

            var parent = container.Resolve<IParent>(new TypedParameter(typeof(string), "Autofac")); // Resolve with additional parameter
            Console.WriteLine(parent.Child.Content);
            parent = container.Resolve<IParent>(new NamedParameter("x", "Autofac 2")); // Second parameter is ignored (singleton)
            Console.WriteLine(parent.Child.Content);

            Console.ReadKey();
        }
    }
}
