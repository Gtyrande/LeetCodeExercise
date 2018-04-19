using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = IsPalindrome(-2147447412);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        static bool IsPalindrome(int x)
        {
            bool result = true;
            string temp = x.ToString();

            int index = temp.IndexOf("-");
            if (index != -1)
            {
                temp = temp.Remove(0, 1);
            }

            char[] charArray = temp.ToCharArray();
            for (int i = 0; i <= charArray.Length / 2; i++)
            {
                if (charArray[i] != charArray[charArray.Length - i - 1])
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
