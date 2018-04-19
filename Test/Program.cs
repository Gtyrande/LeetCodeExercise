using MyCodeLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(1534236469));
            Console.ReadKey();
        }

        static int Reverse(int x)
        {
            try
            {
                bool isNegtive = false;
                string temp = x.ToString();

                int index = temp.IndexOf("-");

                if (index != -1)
                {
                    temp = temp.Remove(0, 1);
                    isNegtive = true;
                }

                char[] charArray = temp.ToCharArray();
                Array.Reverse(charArray);
                temp = new string(charArray);
                int result = Int32.Parse(temp);

                if (isNegtive)
                {
                    result *= -1;
                }

                return result;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }

        static int Reverse1(int n)
        {
            try
            {
                int result = 0;

                while (n != 0)
                {
                    int temp = result * 10 + n % 10;
                    n = n / 10;
                    if (temp / 10 != result)
                    {
                        result = 0;
                        break;
                    }
                    result = temp;
                }
                return result;
            }
            catch (OverflowException)
            {
                return 0;
            }

        }
    }
}
