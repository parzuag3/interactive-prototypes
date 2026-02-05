using System;
//This line of code opens access to files where projects and programs are found.
namespace practice_3
    //This line of code opens the specifically named project made by the user.
{
    class Program
        //This line of code opens the program used for the code editor.
    {
        static void Main(string[] args)
            //This line of code opens access to begin writing code into the project using the chosen program.
        {
            Console.WriteLine("Please input your name: ");
            //This line of code commands the application to write a sequence, being a line of text, which becomes variables.
            string name = Console.ReadLine();
            //This line of code links a chosen variable as a sequence of code units, then gives the user a window to input any value to continue the program.

            Console.WriteLine("Hi there, " + name + "!");
            //This line of code commands the application to write another sequence, now using the value given previously, forming a short conversation with the computer.

            Console.Write("Please input your age: ");
            //This line of code commands the application to write another sequence.
                string inputLine = Console.ReadLine();
            //This line of code links a different chosen variable, and gives the user a chance to input a value.
            int age = int.Parse(inputLine);
            //This line of code takes the value previously given and converts it into a 32-bit integer equivalent.

            Console.Write("In forty years, you will be: ");
            //This line of code commands the application to write another sequence.
            Console.WriteLine(age + 40);
            //This line of code commands the application to write the answer to the age value and the number 40.

            Console.Write("I wonder what computing will be like then!");
            //This line of code commands the application to write another sequence,
            Console.ReadLine();
            //This line of cude commands the application to display the sequence onto the command tab.
        }
    }
}
