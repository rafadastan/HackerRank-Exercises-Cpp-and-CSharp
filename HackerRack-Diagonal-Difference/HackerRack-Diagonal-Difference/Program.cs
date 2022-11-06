using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRack_Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadKey();
        }
    }

    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int diagonalMatrizOne = 0, diagonalMatrizSecond = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                        diagonalMatrizOne += arr[i][j];
                    if ((i + j) == arr.Count - 1)
                        diagonalMatrizSecond += arr[i][j];
                }
            }

            return Math.Abs(diagonalMatrizOne - diagonalMatrizSecond);
        }
    }
}