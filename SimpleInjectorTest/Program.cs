﻿using System;
using Library;
using SimpleInjector;

namespace SimpleInjectorTest
{
    public class Program
    {
        public static void Main()
        {
            var container = new Container();

            var parent = new Parent(container.GetInstance<Child>(), "SimpleInjector"); // Parametr angeben nicht möglich
            Console.WriteLine(parent.Child.Content);

            Console.ReadKey();
        }
    }
}
