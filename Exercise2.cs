using System;

namespace functionsandmethods_2
{
    class Program
    {
        static void Main_2(string[] args)
        {
            string theName = GetInput("Please enter your name");
            print("Greetings " + theName);
            print("Have a nice day");
        }
        static string GetInput(string prompt){
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
        static void print(string input){
            Console.WriteLine(input);
        }
    }
}
