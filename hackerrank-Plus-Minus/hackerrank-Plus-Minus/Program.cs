using System;
using System.Collections.Generic;
using System.Linq;

namespace hackerrank_Plus_Minus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);

            Console.ReadKey();
        }
    }

    public class Result
    {
        public static void plusMinus(List<int> arr)
        {
            double NumZero = 0;
            double NumPositivo = 0;
            double NumNegativo = 0; 

            foreach (var item in arr)
            {
                if (item == 0)
                {
                    NumZero++;
                }
                else if(item > 0)
                {
                    NumPositivo++;
                }
                else if(item < 0)
                {
                    NumNegativo++;
                }
            }

            double totalArray = arr.Count;
            double DivisaoPositivo = NumPositivo / totalArray;
            double DivisaoNegativo = NumNegativo / totalArray;
            double DivisaoZero = NumZero / totalArray;

            Console.WriteLine(" " + DivisaoPositivo.ToString("N6"));
            Console.WriteLine(" " + DivisaoNegativo.ToString("N6"));
            Console.WriteLine(" " + DivisaoZero.ToString("N6"));
        }
    }
}
