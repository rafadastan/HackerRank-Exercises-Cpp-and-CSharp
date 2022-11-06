using System;
using System.Linq;

namespace HackerHank_Caesar_Chiper_Resposta_Certa
{
    class Program
    {
        static void Main(string[] args)
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
            int offset = k % 26;

            string ciphered = "";
            for (int i = 0; i < s.Length; i++)
            {
                char toCipher = s[i];
                int asciiVal = (int)toCipher;

                if (asciiVal > 122 || asciiVal < 65 || (asciiVal > 90 && asciiVal < 97))
                {
                    ciphered += s[i];
                    continue;
                }

                char cipheredChar = (char)(toCipher + offset);
                int cipheredAscii = (int)cipheredChar;

                if ((asciiVal >= 65 && asciiVal <= 90) && cipheredAscii > 90 || (asciiVal >= 97 && asciiVal <= 122) && cipheredAscii > 122)
                {
                    cipheredChar = (char)(cipheredChar - 26);
                }

                ciphered += cipheredChar;
            }

            return ciphered;
        }
        
        static string Chipher(string OriginalText, int Shift)
        {
            char[] originalTextArr = OriginalText.ToCharArray();
            int FirstCharIdx = 'a';
            int offset = ('z' - 'a') + 1; 

            for (int i = 0; i < originalTextArr.Length; i++)
            {
                char oldCharIdx = originalTextArr[i];
                int OldIdxInAlphabet = oldCharIdx - FirstCharIdx;
                int NewIdxInAlphabet = (OldIdxInAlphabet + Shift) % offset;

                char NewCharIdx = (char)(FirstCharIdx + NewIdxInAlphabet);
                originalTextArr[i] = NewCharIdx;
            }

            return new string(originalTextArr);
        }

        static string Decipher(string CipheredText, int Shift)
        {
            return Chipher(CipheredText, Shift * -1);
        }
    }
}
