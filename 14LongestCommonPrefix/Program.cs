using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[]
            {
                //"Fuck",
                //"Fuc-ing",
                //"Fu--er"
                "acb",
                "b",
                "",
                ""
            };

            Console.WriteLine(LongestCommonPrefix(stringArray));
            Console.ReadKey();
        }

        static string LongestCommonPrefix(string[] strs)
        {
            bool isFound = false;
            int length;
            if (strs.Length != 0)
            {
                length = strs[0].Length;
            }
            else
            {
                length = 0;
            }

            for (int i = 0; i < strs.Length; i++)
            {
                length = Math.Min(length, strs[i].Length);
            }

            while (!isFound & length != 0)
            {
                isFound = true;
                for (int i = 0; i < strs.Length; i++)
                {
                    isFound &= strs[i].Substring(0, length) == strs[0].Substring(0, length);
                }
                if (!isFound)
                {
                    length -= 1;
                }
            }

            if (length == 0)
            {
                return "";
            }
            else
            {
                return strs[0].Substring(0, length);
            }
        }
    }
}
