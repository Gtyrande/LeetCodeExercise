using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125ValidPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsParlindrome("A man, a plan, a canal: Panama"));
            Console.ReadKey();
        }

        static bool IsParlindrome1(string s)
        {
            if (s.Length == 0 || s.Length == 1)
            {
                return true;
            }

            string newStr = "";
            for (int i = 0; i < s.Length; i++)
            {
                int tmp = (int)s[i];
                if ((tmp >= 65 && tmp <= 90) || (tmp >= 97 && tmp <= 122) ||
                    (tmp >= 48 && tmp <= 57))
                {
                    newStr += s[i];
                }
            }

            if (newStr.Length == 0 || newStr.Length == 1)
            {
                return true;
            }

            newStr = newStr.ToLower();
            //for (int i = 0; i <= newStr.Length / 2; i++)
            //{
            //    if (newStr[i] != newStr[newStr.Length - i - 1])
            //    {
            //        return false;
            //    }
            //}

            char[] charArray = newStr.ToCharArray();
            Array.Reverse(charArray);
            string secStr = new string(charArray);

            if (newStr != secStr)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool IsParlindrome(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string newStr = new string(charArray);

            string str = s.ToLower();
            newStr = newStr.ToLower();

            if ((System.Globalization.CultureInfo.CurrentCulture.CompareInfo.Compare
                (str, newStr, System.Globalization.CompareOptions.IgnoreSymbols) == 0))
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
