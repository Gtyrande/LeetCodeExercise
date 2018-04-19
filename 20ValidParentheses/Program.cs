using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("()"));
            Console.ReadKey();
        }

        static bool IsValid(string s)
        {
            Stack<char> ts = new Stack<char>();

            char[] charArray = s.ToCharArray();
            foreach (char a in charArray)
            {
                if (a == '(' || a == '[' || a == '{')
                {
                    ts.Push(a);
                }
                if (a == ')' || a == ']' || a == '}')
                {
                    if (ts.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        if ((a == ')' && ts.Peek() == '(') ||
                            (a == ']' && ts.Peek() == '[') ||
                            (a == '}' && ts.Peek() == '{'))
                        {
                            ts.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            if (ts.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
