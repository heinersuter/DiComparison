using System;

namespace Library
{
    public interface IParent
    {
        Child Child { get; }
    }

    public class Parent : IParent
    {
        public Child Child { get; }

        public Parent(Child child, string x)
        {
            Child = child;
            child.Content += x;
            Console.WriteLine("Parent created");
        }
    }

    public class Child
    {
        public Child()
        {
            Console.WriteLine("Child created");
        }

        public string Content { get; set; } = "Hello ";
    }


}
