using System;
using System.Collections.Generic;
using System.Text;

namespace hw_methods_1
{
    static class Extensions
    {
        public static int GetLetterCount(this string s,char c)
        {
            int counter = 0;
            foreach(char i in s)
            {
                if (i == c)
                {
                    counter++;
                }
            }
            return counter;            
        }
    }
}
