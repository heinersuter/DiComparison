using System;
using Library;
using Ninject;
using Ninject.Parameters;

namespace NinjectTest
{
    public class Program
    {
        public static void Main()
        {
            var container = new StandardKernel();
            container.Bind<IParent>().To<Parent>().InSingletonScope();

            var parent = container.Get<IParent>(new ConstructorArgument("x", "Ninject")); // Parameter via Name setzen
            Console.WriteLine(parent.Child.Content);
            parent = container.Get<IParent>(new TypeMatchingConstructorArgument(typeof(string), (context, target) => "Ninject 2")); // Parameter via Typ setzen
            Console.WriteLine(parent.Child.Content);

            Console.ReadKey();
        }
    }
}
