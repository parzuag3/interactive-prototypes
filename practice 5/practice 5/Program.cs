using System;

namespace practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 1");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);

            result = num1 - num2;

            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);

            result = num1 * num2;

            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);

            result = num1 / num2;

            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            Console.ReadKey();
        }
    }
}
