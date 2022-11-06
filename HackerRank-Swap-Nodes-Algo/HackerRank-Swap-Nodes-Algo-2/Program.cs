using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_Swap_Nodes_Algo_2
{
    class Program
    {
        static void Main(String[] args)
        {
            var nodes = new Dictionary<int, List<int>>();
            var levels = new Dictionary<int, List<int>>();
            levels.Add(1, new List<int> { 1 });
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                var input = Console.ReadLine().Split();
                nodes.Add(i, new List<int> { int.Parse(input[0]), int.Parse(input[1]) });
            }

            var level = 1;
            while (true)
            {
                var nextLevel = new List<int>();
                foreach (var node in levels[level])
                {
                    nextLevel.AddRange(nodes[node].Where(x => x > 0));
                }

                if (nextLevel.Any())
                {
                    level++;
                    levels[level] = nextLevel;
                }
                else break;
            }

            var qs = int.Parse(Console.ReadLine());
            for (int _ = 0; _ < qs; _++)
            {
                var k = int.Parse(Console.ReadLine());
                var i = 1;

                while (true)
                {
                    if (levels.ContainsKey(k * i))
                    {
                        foreach (var node in levels[k * i])
                        {
                            var temp = nodes[node][0];
                            nodes[node][0] = nodes[node][1];
                            nodes[node][1] = temp;
                        }
                        i++;
                    }
                    else break;
                }

                traverse(1, nodes);
                Console.WriteLine();
            }
        }

        public static void traverse(int n, Dictionary<int, List<int>> nodes)
        {
            var node = nodes[n];
            var left = node[0];
            var right = node[1];
            if (left > 0) traverse(left, nodes);
            Console.Write(n + " ");
            if (right > 0) traverse(right, nodes);
        }
    }
}
