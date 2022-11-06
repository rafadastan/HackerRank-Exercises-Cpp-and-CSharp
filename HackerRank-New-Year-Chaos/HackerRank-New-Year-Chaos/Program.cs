using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_New_Year_Chaos
{
    internal static class Result
    {

        /*
         * Complete the 'minimumBribes' function below.
         *
         * The function accepts INTEGER_ARRAY q as parameter.
         */

        public static void MinimumBribes(List<int> questions)
        {
            var forwardPosition = 0;
            var atualPosition = 0;
            var amountOfBribe = 0;
            var message = string.Empty;
            var countArray = questions.Count;

            for (var i = 0; i < countArray; i++)
            {
                forwardPosition = questions[i + 1];
             
                atualPosition = questions[i];
                var amount = atualPosition - forwardPosition;
                var valideIfAmountIsGreater = atualPosition > forwardPosition;

                if (Math.Abs(amount) == 1 && valideIfAmountIsGreater)
                {
                    amountOfBribe ++;
                }
                else if (Math.Abs(amount) == 2 && valideIfAmountIsGreater)
                {
                    amountOfBribe++;
                    message = "Too chaotic";
                }
                else if (valideIfAmountIsGreater && (Math.Abs(amount) == 3 || Math.Abs(amount) > 3 ))
                {
                    amountOfBribe++;
                    message = "Too chaotic";
                }
            }

            Console.WriteLine(amountOfBribe);
            Console.WriteLine(message);
        }
    }

    internal static class Program
    {
        private static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine()?.Trim());

            for (var tItr = 0; tItr < t; tItr++)
            {
                var n = Convert.ToInt32(Console.ReadLine()?.Trim());

                var q = Console.ReadLine()?.TrimEnd().Split(' ')
                    .ToList()
                    .Select(qTemp => Convert.ToInt32(qTemp))
                    .ToList();

                Result.MinimumBribes(q);
            }
        }
    }
}
