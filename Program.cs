using System;

namespace functionsandmethods
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
 
        public static void Main() 
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of individual digits in the number "+ num + " is " + Sum(num));    
        }
            
        static void print(string input){
            Console.WriteLine(input);
        }
    }
}
