using System;

namespace MyLib
{
    public class Greeter
    {
        public void Greet(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception();


            Console.WriteLine($"Hello, {name}!");
        }

    }
}
