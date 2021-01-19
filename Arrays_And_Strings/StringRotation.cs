using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    /*
     * Question : Assume you have a metho isSubstring which checks if one word is a substring of another.Givent two strings s1 and s2, write code to check if
     * s2 is rotation of s1 using only one call to isSubstring.
     */
    class StringRotation
    {
        public bool isRotation(string a, string b)
        {
            return isSubstring(a + a, b);
        }

        public bool isSubstring(string a, string b)
        {
            return a.Contains(b);
        }
    }
}
