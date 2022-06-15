using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReverseString
    {
        static void main()
        {

            char[] chars = "abcdef".ToCharArray();
            string stringvalue = string.Empty;
            for (int i = 0, j = chars.Length - 1; i < chars.Length; i++, j--)
            {
                stringvalue += chars[j];
            }
            Console.WriteLine(stringvalue);

            Console.ReadLine();
        }
    }

}
