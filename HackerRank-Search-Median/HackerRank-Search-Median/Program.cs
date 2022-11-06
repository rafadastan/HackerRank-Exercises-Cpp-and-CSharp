using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_Search_Median
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.findMedian(arr);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

    class Result
    {

        /*
         * Complete the 'findMedian' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int findMedian(List<int> arr)
        {
            List<int> _values = new List<int>();
            for (int i = 0; i < arr.Count; i++)
                _values.Add(Convert.ToInt32(arr[i]));

            _values.Sort();

            var values = _values[_values.Count / 2];

            Console.WriteLine($"VALOR: {_values.ToArray()} " + values);

            return _values[_values.Count / 2];
        }
    }
}
