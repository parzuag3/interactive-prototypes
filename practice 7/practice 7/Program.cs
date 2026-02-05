using System;

namespace practice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 11)
            {
                Console.WriteLine(i);
                ++i;
            }
            Console.ReadLine();

            for (int o = 1; o <= 100; o++)
            {
                if (o % 3 == 0)
                {
                    Console.WriteLine(o + " Fizz");
                }
                else
                {
                    Console.WriteLine(o);
                }
            }
        }
    }
}