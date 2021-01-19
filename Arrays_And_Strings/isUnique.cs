using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    /* Question 1 : Implement an algorithm to determine if a string has all unique characters.
     * Follow Up : What if you cannot use additional data structure.
     */
    class isUnique
    {
        /*
         * Approach 1 - Using Extra Space - CharMap - an integer array to mark the presence of characters.
         * Ask the interviewer if its just alphabets or all possible characters in the range of 0-256.
         * If alphabets and only lower case or upper case then you will need a char_map of size 26.
         * Alternatively you can also use a HashSet<char>.
        */
        public bool is_stringunique(string s)
        {
            HashSet<char> set = new HashSet<char>();

            foreach(char c in s)
            {
                if (set.Contains(c))
                    return false;
                else
                    set.Add(c);
            }
            return true;
        }

        //Approach 2 using a char_map for 256 Extended ASCII characters. [if only AScii then 128 size].

        public bool is_stringunique2(string s)
        {
            if (s.Length > 256)
                return false;

            bool[] char_map = new bool[256];

            for(int i = 0; i < s.Length; i++)
            {
                if (char_map[Convert.ToInt32(s[i])])
                    return false;
                else
                    char_map[Convert.ToInt32(s[i])] = true;
            }

            return true;                  
        }

        /*Approach 3 - Without using Extra space
         * If input string can be modified then sort and compare consecutive characters for duplicate. T(n) = O(nlogn), n = length of string
         * If input cannot be modified then compare every character against each character. T(n) = O(n^2) , n = length of string
         */

        public bool is_stringunique3(string s)
        {
            
            char[] c = s.ToCharArray();

            if (c.Length == 1)
                return true;
            else if (c.Length > 256)
                return false;

            Array.Sort(c);

            for(int i = 1; i < c.Length; i++)
            {
                if (c[i].Equals(c[i - 1]))
                    return false;
            }

            return true;
        }
    }
}
