using System;

namespace functionsandmethods_6
{
    class Program
    {
        public static void swapper(int newNum1, int newNum2){
            int newNum3;
            newNum3 = newNum1;
            newNum1 = newNum2;
            newNum2 = newNum3;
        }
        public static void Main_6(string[] args)
        {
           int num1, num2;
           Console.WriteLine("Enter a number: ");
           num1 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter another number: ");
           num2 = Convert.ToInt32(Console.ReadLine());
           swapper(num1, num2);
           Console.WriteLine("jokes on u the numbers have been swapped, number 1 is now " + num1 + ", and number 2 is now " + num2);
        }
    }
}
