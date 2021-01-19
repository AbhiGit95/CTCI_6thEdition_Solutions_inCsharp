using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    /*
     * Question : Given a string write a function to check if it is a permutation of a palindrome.
     * Intution : For a string to be a permutation of a palindrome. We need to check if all the characters in the string have either even occurrences or 
     * there is only one character which has an odd number of occurrence and rest all have even number of occurrence.
     */
    class PalindromePermutation
    {
        public bool check_palindrome(string a)
        {
            int[] char_map = new int[256];

            foreach(char c in a)
            {
                char_map[Convert.ToInt32(c)] += 1;
            }

            bool odd = false;

            foreach(int i in char_map)
            {
                if (i % 2 != 0 && !odd)
                {
                    odd = true;
                }

                else if (i % 2 != 0 && odd)
                    return false;
            }

            return true;
        }

    }
}
