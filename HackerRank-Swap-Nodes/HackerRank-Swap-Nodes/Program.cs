using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_Swap_Nodes
{
    class Result
    {

        /*
         * Complete the 'swapNodes' function below.
         *
         * The function is expected to return a 2D_INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. 2D_INTEGER_ARRAY indexes
         *  2. INTEGER_ARRAY queries
         */

        public static List<List<int>> swapNodes(List<List<int>> indexes, List<int> queries)
        {
            foreach (var index in indexes)
            {
                for (var j = 0; j < indexes.Count; j++)
                {
                    
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> indexes = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                indexes.Add(Console.ReadLine().TrimEnd()
                    .Split(' ')
                    .ToList()
                    .Select(indexesTemp => Convert.ToInt32(indexesTemp))
                    .ToList());
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> queries = new List<int>();

            for (int i = 0; i < queriesCount; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }

            List<List<int>> result = Result.swapNodes(indexes, queries);

            Console.WriteLine(result);
        }
    }
}
