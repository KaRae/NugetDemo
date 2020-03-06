using MyLib;
using System;
using System.Collections.Generic;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<string> { "Ada", "Bernard", "Charlie", "" };
            var greeter = new Greeter();

            persons.ForEach(person => greeter.Greet(person));


            Console.ReadLine();
        }
    }
}
