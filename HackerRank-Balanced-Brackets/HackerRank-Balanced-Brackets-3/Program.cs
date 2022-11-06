using System;
using System.Collections.Generic;

namespace HackerRank_Balanced_Brackets_3
{
    class Solution
    {
        static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.In.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var input = Console.ReadLine();
                var stack = new Stack<char>();
                var isValid = true;
                foreach (char t in input)
                {
                    switch (t)
                    {
                        case '(':
                            stack.Push(t);
                            break;

                        case '[':
                            stack.Push(t);
                            break;

                        case '{':
                            stack.Push(t);
                            break;

                        case ')':
                            if (stack.Count == 0 || stack.Pop() != '(')
                            {
                                isValid = false;
                            }

                            break;

                        case ']':
                            if (stack.Count == 0 || stack.Pop() != '[')
                            {
                                isValid = false;
                            }

                            break;

                        case '}':
                            if (stack.Count == 0 || stack.Pop() != '{')
                            {
                                isValid = false;
                            }

                            break;
                    }

                    if (isValid == false)
                    {
                        break;
                    }
                }

                Console.WriteLine(isValid && stack.Count == 0 ? "YES" : "NO");
            }
        }
    }
}
