using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace HackerRank_Balanced_Brackets_2
{
    class Result
    {

        /*
         * Complete the 'isBalanced' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string isBalanced(string s)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{' || s[i] == '(' || s[i] == '[') stack.Push(s[i]);

                if (stack.Count == 0)
                    return null;

                if (s[i] == '}' || s[i] == ')' || s[i] == ']')
                {
                    if (stack.Count == 0)
                        return "NO";

                    if (!isMatchingPair(stack.Pop(), s[i]))
                        return "NO";
                }
            }

            if (stack.Count == 0)
                return "YES";
            else
                return "NO";
        }

        private static bool isMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
            {
                return true;
            }
            else if (character1 == '{' && character2 == '}')
            {
                return true;
            }
            else if (character1 == '[' && character2 == ']')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine()?.Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = Result.isBalanced(s);

                Console.WriteLine(result);
                //textWriter.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
