using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_Estagio.Questions
{
    internal class Fifth
    {
        public static void ReverseString(string str)
        {
            char[] strToChar = str.ToCharArray();
            int strSize = str.Length;
            int counter = 0;
            char[] reversedstr = new char[strSize];
            while (strSize > 0) 
            {
                reversedstr[strSize-1] = strToChar[counter];

                counter++;
                strSize--;
            }
            Console.WriteLine(reversedstr + "\n\n");
        }
    }
}
