using System;

namespace functionsandmethods_4
{
    class Program
    {
        static void Main_4(string[] args)
        {
            string teststring = GetInput("Enter a string");
            Console.WriteLine('"' + teststring + '"' + " contains " + count(teststring) + " spaces");
        }
        static string GetInput(string prompt){
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
        static int count(string str){
            int strCount = 0;
            string test2;
            for (int i = 0; i < str.Length; i++)
            {
                test2 = str.Substring(i, 1);
                if (test2 == " ")
                    strCount++;
            }
            return strCount;
        }
        static void print(string input){
            Console.WriteLine(input);
        }
    }
}
