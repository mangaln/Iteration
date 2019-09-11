using System;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello many years experience do you have in professional programming");
                int years = int.Parse(Console.ReadLine());
                for (int i = 1; i <=years; i++)
                {
                    Console.WriteLine("You have " + i + " years of experience");

                }

            }
            catch
            {
                Console.WriteLine("Please enter Integer");
            }
        }
    }
}
