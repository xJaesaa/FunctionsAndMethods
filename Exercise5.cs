using System;

namespace functionsandmethods_5
{
    class Program
    {
        public static int Sum(int[] myArray){
            int total = 0;
            for(int i = 0; i < myArray.Length; i++){
                total += myArray[i];
            }
            return total;
        }
        public static void Main_5(string[] args)
        {
            int[] myArray = new int[5];
            Console.WriteLine("Enter numbers for the array:");
            for(int x = 0; x < 5; x++){
                Console.Write("index: " + x + ": ");
                myArray[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum of the array is {0}", Sum(myArray));
        }
    }
}
