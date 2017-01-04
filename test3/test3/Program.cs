using System;

namespace test3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter who you love:");

            string Name = Console.ReadLine();

            Console.WriteLine("Would you merry me, {0}?", Name);

            Console.WriteLine("Would you merry me, " + Name + "?");

            Console.WriteLine("Please enter your name:");

            string Lastname = Console.ReadLine();

            string Firstname = Console.ReadLine();

            Console.WriteLine("Your name is {0} {1}", Lastname, Firstname);
        }
    }
}
