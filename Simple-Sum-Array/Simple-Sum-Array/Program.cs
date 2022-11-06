using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Simple_Sum_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 10, 11 };

            int result = Result.simpleArraySum(list);

            Console.WriteLine("Resultado: " + result);
        }
    }

    class Result
    {

        /*
         * Complete the 'simpleArraySum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY ar as parameter.
         */

        public static int simpleArraySum(List<int> ar)
        {
            return ar.Sum(x => x);
        }
    }
}
