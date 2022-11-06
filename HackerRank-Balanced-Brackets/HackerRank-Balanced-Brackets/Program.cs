﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HackerRank_Balanced_Brackets
{
    public class BalancedBrackets
    {
        public class Stack
        {
            public int top = -1;
            public char[] items = new char[100];

            public void push(char x)
            {
                if (top == 99)
                {
                    Console.WriteLine("Stack full");
                }
                else
                {
                    items[++top] = x;
                }
            }

            char pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Underflow error");
                    return '\0';
                }
                else
                {
                    char element = items[top];
                    top--;
                    return element;
                }
            }

            bool isEmpty()
            {
                return (top == -1) ? true : false;
            }
        }

        static bool isMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
            {
                return true;
            }
            else if (character1 == '{' && character2 == '}')
            {
                return true;
            }else if (character1 == '[' && character2 == ']')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool areBracketsBalanced(char[] exp)
        {
            var st = new Stack<char>();

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[') st.Push(exp[i]);

                if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                {
                    if (st.Count == 0)
                        return false;

                    if (!isMatchingPair(st.Pop(), exp[i]))
                        return false;

                }
            }

            if (st.Count == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            char[] exp = { '{', '[', '(', ']', ')', '}' };

            // Function call
            if (areBracketsBalanced(exp))
                Console.WriteLine("Balanced ");
            else
                Console.WriteLine("Not Balanced ");

            Console.ReadKey();
        }
    }
}
