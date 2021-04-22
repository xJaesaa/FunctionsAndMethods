using System;

namespace functionsandmethods_9
{
    class Program
    {
        public static bool prime(int num)
        {
            for (int i = 2; i < num; i++){
                if (num %i == 0){
                    return false;
                }
            }
            return true;
        }
        public static void Main_9()
        {
            Console.WriteLine("Enter a number:");
            int x = int.Parse(Console.ReadLine());	
        
            if (prime(x)){
                Console.WriteLine(x + " is a prime number");
            }
            else{
                Console.WriteLine(x + " is not a prime number");
            }
        }
    }
}
