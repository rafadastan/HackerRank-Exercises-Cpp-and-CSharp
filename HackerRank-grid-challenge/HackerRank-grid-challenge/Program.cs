using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_grid_challenge
{
    class Result
    {

        /*
         * Complete the 'gridChallenge' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING_ARRAY grid as parameter.
         */

        public static string gridChallenge(List<string> grid)
        {
            var count = 0;
            var index = 0;
            
            //Seleciona na lista de grid os itens e ordena todos eles.
            var orderedList = grid
                .Select(item => 
                    string.Concat(item.OrderBy(c => c)))
                .ToList();

            while (index < orderedList[0].Length)
            {
                for (var i = 0; i < orderedList.Count - 1; i++)
                {
                    if ((int)orderedList[i][index] <= (int)orderedList[i + 1][index])
                        count++;
                }
                index++;
            }

            return count == orderedList[0].Length * (orderedList.Count - 1) ? "YES" : "NO";
        }
    }

    static class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var t = Convert.ToInt32(Console.ReadLine()?.Trim());

            for (var tItr = 0; tItr < t; tItr++)
            {
                var n = Convert.ToInt32(Console.ReadLine()?.Trim());

                var grid = new List<string>();

                for (var i = 0; i < n; i++)
                {
                    var gridItem = Console.ReadLine();
                    grid.Add(gridItem);
                }

                var result = Result.gridChallenge(grid);

                Console.WriteLine(result);
            }
        }
    }
}


public class Test
{
    public static string Testando(List<string> grid)
    {
        var orderedList = new List<string>();
        var count = 0;
        var index = 0;
        foreach (var item in grid)
            orderedList.Add(String.Concat(item.OrderBy(c => c)));

        while (index < orderedList[0].Length)
        {
            for (int i = 0; i < orderedList.Count - 1; i++)
            {
                if ((int)orderedList[i][index] <= (int)orderedList[i + 1][index])
                    count++;
            }
            index++;
        }
        if (count == orderedList[0].Length * (orderedList.Count - 1))
            return "YES";
        else
            return "NO";
    }
}