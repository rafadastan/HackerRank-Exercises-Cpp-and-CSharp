using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_Flipping_the_Matrix
{
    internal static class Result
    {
        public static int FlippingMatrix(List<List<int>> matrix)
        {
            var valueN = matrix.Count / 2;
            var sum = 0;

            for (var i = 0; i < valueN; i++)
            {
                for (var j = 0; j < valueN; j++)
                {
                    var maxValue = 0;
                    maxValue = Math.Max(matrix[i][j], maxValue);
                    maxValue = Math.Max(matrix[2 * valueN - i - 1][j], maxValue);
                    maxValue = Math.Max(matrix[i][2 * valueN - j - 1], maxValue);
                    maxValue = Math.Max(matrix[2 * valueN - i - 1][2 * valueN - j -1], maxValue);
                    sum += maxValue;
                }
            }

            return sum;
        }
    }

    internal static class Solution
    {
        public static void Main(string[] args)
        {
            var q = Convert.ToInt32(Console.ReadLine()?.Trim());
            var matrix = new List<List<int>>();
            
            for (var qItr = 0; qItr < q; qItr++)
            {
                var n = Convert.ToInt32(Console.ReadLine()?.Trim());

                for (var i = 0; i < 2 * n; i++)
                {
                    matrix.Add(Console.ReadLine()?.TrimEnd().Split(' ').ToList()
                        .Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
                }

                var result = Result.FlippingMatrix(matrix);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
