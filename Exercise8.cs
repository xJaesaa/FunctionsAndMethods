using System;

namespace functionsandmethods_8
{
    class Program
    {
        public static int fibonacci(int fib)
        {
            int num1 = 0;
            int num2 = 1;
            for(int i = 0; i < fib; i++){
                int num3 = num1;
                num1 = num2;
                num2 = num3 + num2;
            }
            return num1;
        }
        public static void Main_8(string[] args)
        {
            Console.WriteLine("Enter total units: ");
            int x = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The Fibonacci sequence of "+ x +" numbers is:");	  
            for (int i = 0; i < x; i++)
            {
                Console.Write(fibonacci(i)+"  ");
            }

            Console.WriteLine();
        }
    }
}
