using System;

namespace practice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 10;
            Console.WriteLine(first);
            int second = 4;
                Console.WriteLine(second);
            int third = 5;
                Console.WriteLine(third);
            Console.WriteLine("x = 10 - 4 / 5. What is the sum value of x?");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 10)
            {
                Console.WriteLine("Correct!");
            }
            else if (answer <= 10)
            {
                Console.WriteLine("Sorry, wrong answer. The answer is:");
                    }
            else if (answer >= 10)
            {
                Console.WriteLine("Sorry, wrong answer. The answer is:");
            }

            int sum = first - second / third;
            Console.WriteLine(sum);
            Console.ReadLine();

            int sum1 = (first - second) / third;
            Console.WriteLine(sum1);
        }
    }
}
