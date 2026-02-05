using System;

namespace practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a Shape: 1) Rectangle, 2) Diamond");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer < 2)
            {
                Console.WriteLine("***");
                Console.WriteLine("* *");
                Console.WriteLine("***");
            }
            else if (answer == 2)
            {
                Console.WriteLine(" *");
                Console.WriteLine("***");
                Console.WriteLine(" *");
            }
            else if (answer >= 2)
            {
                Console.WriteLine("There is no option for that.");
            }
        }
    }
}
