using System;

namespace functionsandmethods_7
{
    class Program
    {
        public static int tothepower(int n1, int n2)
        {
            int power = 1;
            for (int i = 1; i <= n2; i++){
                power = power * n1;
            }
            return power;
        }
        public static void Main_7(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("To the power of: ");
            int num2 = int.Parse(Console.ReadLine());	

            Console.WriteLine(num1 + " to the power of " + num2 + " = " + tothepower(num1, num2));
        }
    }
}
