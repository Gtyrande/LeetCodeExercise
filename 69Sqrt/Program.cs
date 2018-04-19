using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(4));
            Console.ReadKey();
        }

        static int MySqrt(int x)
        {
            int i = 0;
            while (!(Math.Pow(i, 2) <= x && Math.Pow(i + 1, 2) > x))
            {
                i++;
            }
            return i;
        }
    }
}
