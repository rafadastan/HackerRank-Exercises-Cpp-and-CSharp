using System;
using System.Collections.Generic;
using System.Linq;

namespace MinAndMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);

            Console.ReadKey();
        }    
    }

    class Result
    {
        public static void miniMaxSum(List<int> arr)
        {
            Int64 valMax = arr.Max();
            Int64 valMin = arr.Min();
            Int64 somatorio = 0;
            var hasNumberEquals = arr.Any(x => x != arr[0]);

            if (!hasNumberEquals)
            {
                arr.Remove(arr[0]);
            }

            Int64 min = 0;
            Int64 max = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if ((arr[i] != valMax) || !hasNumberEquals)
                {
                    somatorio = checked((Int64)(min = min + arr[i]));
                    min = somatorio;
                }

                if ((arr[i] != valMin) || !hasNumberEquals)
                {
                    somatorio = checked((Int64)(max = max + arr[i]));
                    max = somatorio;
                }
            }

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine(min + " " + max);
        }
    }
}
