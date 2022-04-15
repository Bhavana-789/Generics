using System;

namespace GenericsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Program\n");
            Console.WriteLine("1:FindMaximum\n2:FindMaxFloatValues\n3:FindMaxString");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    int result = FindMaximum.FindMax(56, 45, 30);
                    Console.WriteLine(result);
                    break;
                case 2:
                    float result1= FindMaximum.FindMax(56.22f, 45.3f, 30.5f);
                    Console.WriteLine(result1);
                    break;
                case 3:
                    string result2=FindMaximum.FindMax("car","bus","train");
                    Console.WriteLine(result2);
                    break;


            }
        }
    }
}
