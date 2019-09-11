using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have in professional programming?");
            string exp = Console.ReadLine();
            for(int i = 0; i < int.Parse(exp) ; i++)
            {
                Console.WriteLine("You have " + (i+1) + " years of experience!");
            }
        }
    }
}
