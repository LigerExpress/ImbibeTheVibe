using System;

namespace first_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("You can press a key to continue.");
            string x;
            string b;
            x = "a";

            b = Console.ReadLine();
            if (b == x)
            { Console.WriteLine("move on"); 
            }
               
            else Console.WriteLine("denied");
        }
    }
}
