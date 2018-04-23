using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string normalString;
            string[] words;
            char[] reverse;
            while(true)
            {
                Console.Clear();
                Console.Write("Is it a palindrome?\nEnter some words to find out: ");
                normalString = Regex.Replace(Console.ReadLine().ToLower(), @"\s+", " ");
                Console.WriteLine();
                words = normalString.Split(' ');

                foreach (string s in words)
                {
                    reverse = s.ToCharArray();
                    Array.Reverse(reverse);
                    if (s == String.Join("", reverse))
                        Console.WriteLine(s + " is a palindrome!");
                    else
                        Console.WriteLine(s + " is not a palindrome.");
                }

                Console.Write("\nWould you like to try again? Enter Y or N: ");
                if (Regex.Replace(Console.ReadLine().ToLower(), @"\s+", " ") == "n")
                    break;
            }
        }
    }
}
