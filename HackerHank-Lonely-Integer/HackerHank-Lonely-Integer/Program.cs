using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerHank_Lonely_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.lonelyinteger(a);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadKey();
        }
    }

    class Result
    {

        /*
         * Complete the 'lonelyinteger' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static int lonelyinteger(List<int> a)
        {
            int sumPositionUnpaired = a[0];

            for (int i = 1; i < a.Count; i++)
            {
                Console.WriteLine($"POSIÇÃO: {i}, VALOR: {a[i]}, POSIÇÃO INICIAL: {sumPositionUnpaired}");
                Console.WriteLine();
                sumPositionUnpaired = sumPositionUnpaired ^ a[i];
            }

            Console.WriteLine("VALOR: " + sumPositionUnpaired);

            return sumPositionUnpaired;
        }
    }
}
