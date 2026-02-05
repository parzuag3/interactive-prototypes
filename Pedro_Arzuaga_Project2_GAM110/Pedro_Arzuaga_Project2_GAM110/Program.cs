using System;
using System.Diagnostics;


namespace Pedro_Arzuaga_Project2_GAM110
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 51);
            int num2 = rnd.Next(1, 51);
            string answer;
            bool[] answerCheck = new bool[5];
            Stopwatch sw = new Stopwatch();
            string[] operators = { "+", "-", "*", "/" };
            int rndOperator = rnd.Next(0, 3);
            int problemCount = 0;

            do
            {
                Console.Write("Problem " + (problemCount + 1) + ": ");
                Console.WriteLine(num1 + " " + operators[rndOperator] + " " + num2);
                sw.Start();
                Console.Write("Solution: ");
                answer = Console.ReadLine();
                if (operators[rndOperator] == "+")
                {
                    if (int.Parse(answer) == num1 + num2)
                    {
                        answerCheck[problemCount] = true;
                    }
                    else
                    {
                        answerCheck[problemCount] = false;
                    }
                }
                if (operators[rndOperator] == "-")
                {
                    if (int.Parse(answer) == num1 - num2)
                    {
                        answerCheck[problemCount] = true;
                    }
                    else
                    {
                        answerCheck[problemCount] = false;
                    }
                }
                if (operators[rndOperator] == "*")
                {
                    if (int.Parse(answer) == num1 * num2)
                    {
                        answerCheck[problemCount] = true;
                    }
                    else
                    {
                        answerCheck[problemCount] = false;
                    }
                }
                if (operators[rndOperator] == "/")
                {
                    if (int.Parse(answer) == num1 / num2)
                    {
                        answerCheck[problemCount] = true;
                    }
                    else
                    {
                        answerCheck[problemCount] = false;
                    }
                }
                num1 = rnd.Next(1, 51);
                num2 = rnd.Next(1, 51);
                rndOperator = rnd.Next(0, 3);
                problemCount = problemCount + 1;
                Console.WriteLine();
            } while (problemCount != 5);

            sw.Stop();
            Console.WriteLine();
            int correctCount = 0;
            for (int i = 0; i < 5; i++)
            {
                if (answerCheck[i])
                {
                    Console.WriteLine("You answered Problem " + (i + 1) + " correctly. Well done!");
                    correctCount += 1;
                }
                else
                {
                    Console.WriteLine("Yikes, you answered Problem " + (i + 1) + " incorrectly.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Elapsed Time: " + sw.Elapsed);

            if (correctCount == 0)
            {
                Console.WriteLine("Eh, at least you gave it your all, right?... Right?");
            }
            if (correctCount == 1)
            {
                Console.WriteLine("Only one correct answer, huh? I mean, could be worse.");
            }
            if (correctCount == 2)
            {
                Console.WriteLine("Two correct answers, close to halfway decent.");
            }
            if (correctCount == 3)
            {
                Console.WriteLine("Three correct answers, not bad, but not good.");
            }
            if (correctCount == 4)
            {
                Console.WriteLine("Four out of fine correct answers, that's still a passing grade. Keep up the good work.");
            }
            if (correctCount == 5)
            {
                Console.WriteLine("PERFECT! This computer could use brainiacs like you. Go treat yourself with your newly-earned bragging rights.");
            }
        }
    }
}
