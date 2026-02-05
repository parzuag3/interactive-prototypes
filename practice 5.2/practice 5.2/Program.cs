using System;

namespace practice_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "2";
            int num2 = Int32.Parse(num);

            Console.WriteLine(num2);

            string num3 = "4";
            int num4 = Int32.Parse(num3);
            
            Console.WriteLine(num3);

            int
            
            result = num2 + num4;

            Console.WriteLine("{0} + {1} = {2}",num2,num4,result);

            result = num2 - num4;

            Console.WriteLine("{0} - {1} = {2}",num2,num4,result);

            result = num2 * num4;

            Console.WriteLine("{0} * {1} = {2}",num2,num4,result);

            result = num2 / num4;

            Console.WriteLine("{0} / {1} = {2}",num2,num4,result);
            Console.ReadKey();
        }
    }
}
