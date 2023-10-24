using System;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter  a string");
                string input = Console.ReadLine();
                string reverse = string.Empty;

                int lenght = input.Length - 1;
                while (lenght >= 0)
                {
                    reverse = reverse + input[lenght];
                    lenght--;
                }
                if (input == reverse)
                {
                    Console.WriteLine($"{input} is a palindrome string");

                }
                else
                {
                    Console.WriteLine($"{input} is not a palindrome string");
                }
                Console.WriteLine("Do you want to check another palindrome ? (yes/no)");
                string choice = Console.ReadLine().ToLower();
                if (choice != "yes")
                {
                    break;
                }
            }
        
        
        }
    }
}
