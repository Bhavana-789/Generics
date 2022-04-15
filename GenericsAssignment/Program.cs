using System;

namespace GenericsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Program\n");
            Console.WriteLine("1:FindMaximum");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    int result = FindMaximum.FindMaxInteger(56, 45, 30);
                    Console.WriteLine(result);
                    break;

            }
        }
    }
}
