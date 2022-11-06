using System;

namespace PalindromeIndex
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine() ?? string.Empty);
            for (var i = 0; i < t; i++)
            {
                PalindromeIndex();
            }
        }

        private static void PalindromeIndex()
        {
            var str = Console.ReadLine();
            var i = 0;
            if (str == null) return;
            var j = str.Length - 1;

            while (i < j)
            {
                if (str[i] == str[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    Console.WriteLine(IsPalindrome(str.Substring(i, j - i)) ? j : i);
                    break;
                }
            }

            if (i >= j)
            {
                Console.WriteLine(-1);
            }
        }

        private static bool IsPalindrome(string str)
        {
            var i = 0;
            var j = str.Length - 1;

            while (i < j)
            {
                if (str[i] == str[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}