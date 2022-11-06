using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HackerHank_Caesar_Chiper
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.caesarCipher(s, k);

            Console.WriteLine(result);
            Console.ReadKey();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

    class Result
    {
        /*
         * Complete the 'caesarCipher' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. INTEGER k
         */

        public static string caesarCipher(string s, int k)
        {
            char[] originalTextArr = s.ToCharArray();
            int FirstCharIdx = 'a';
            int offset = k % 26;

            for (int i = 0; i < originalTextArr.Length; i++)
            {
                char oldCharIdx = originalTextArr[i];
                int OldIdxInAlphabet = oldCharIdx - FirstCharIdx;
                int NewIdxInAlphabet = (OldIdxInAlphabet + k) % offset;

                char NewCharIdx = (char)(FirstCharIdx + NewIdxInAlphabet);
                originalTextArr[i] = NewCharIdx;
            }

            return new string(originalTextArr);
        }

        static string Decipher(string CipheredText, int Shift)
        {
            return caesarCipher(CipheredText, Shift * -1);
        }
    }
}
