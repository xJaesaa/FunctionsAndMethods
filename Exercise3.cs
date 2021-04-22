using System;

namespace functionsandmethods_3
{
    class Program
    {
        static void Main_3(string[] args)
        {
            int num1 = Convert.ToInt32(GetInput("Enter a number"));
            int num2 = Convert.ToInt32(GetInput("Enter another number"));
            sum(num1, num2);
            Console.WriteLine("The sum is: " + sum(num1,num2));
        }
        static string GetInput(string prompt){
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
        static int sum(int num1, int num2){
            int total;
            total = num1 + num2;
            return total;
        }
    }
}
