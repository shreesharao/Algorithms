using System;
using System.Collections.Generic;

namespace BalancedString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(IsBalancedString(input));
            Console.Read();
        }

        private static bool IsBalancedString(string input)
        {
            Stack<char> stack = new Stack<char>();
            char character;
            foreach (var chr in input)
            {
                switch (chr)
                {
                    case '(':
                        stack.Push(chr);
                        break;
                    case ')':
                        character = stack.Pop();
                        if (character == '(')
                        {
                            continue;
                        }
                        return false;
                    case '[':
                        stack.Push(chr);
                        break;
                    case ']':
                        character = stack.Pop();
                        if (character == '[')
                        {
                            continue;
                        }
                        return false;

                    case '<':
                        stack.Push(chr);
                        break;
                    case '>':
                        character = stack.Pop();
                        if (character == '<')
                        {
                            continue;
                        }
                        return false;

                    default:
                        break;
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
