using System;

namespace functionsandmethods_10
{
    class Program
    {
        public static int Sum(int x) 
        { 
            string num1 = Convert.ToString(x);
            int sum = 0;  
            for (int i = 0; i < num1.Length; i++){
                sum += int.Parse(num1.Substring(i,1));
            }
            return sum;
        }
 
        public static void Main_10() 
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of individual digits in the number "+ num + " is " + Sum(num));    
        }
    }
}
