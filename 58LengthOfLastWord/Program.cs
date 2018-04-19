using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58LengthOfLastWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("b  a  "));
            Console.ReadKey();
        }

        static int LengthOfLastWord(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);

            string temp = new string(charArray);
            if (temp.Length > 0 && charArray[0] == ' ')
            {
                temp = temp.TrimStart(' ');
            }

            int index = temp.IndexOf(' ');
            if (index >= 0)
            {
                return index;
            }
            else if (temp.Length > 0)
            {
                return temp.Length;
            }
            else
            {
                return 0;
            }
        }
    }
}
