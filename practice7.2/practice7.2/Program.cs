using System;

namespace practice7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter a width");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a height");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num1; i++)
            {
                for (int j = 1; j <= num2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
