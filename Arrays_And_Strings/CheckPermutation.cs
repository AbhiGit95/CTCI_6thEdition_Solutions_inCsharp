using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    /*
     * Question - Given two strings, write a method to decide if one is a permutation of the other 
     */

    class CheckPermutation
    {
        /* Method1 - Sort both the strings and check if they are identical.
         * Also before sorting check for the length of the strings if they are same or not.
         * Sorting will dominate so it will take T(n) : O(nlogn)
         */
        public bool check_permutation(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            char[] arr_a = a.ToCharArray();
            char[] arr_b = b.ToCharArray();

            Array.Sort(arr_a); Array.Sort(arr_b);

            for(int i = 0; i < a.Length; i++)
            {
                if (arr_a[i] != arr_b[i])
                    return false;
            }

            return true;
        }

        /* Method2 - Maintain a char_map for one of the strings. Then iterate through the 2nd string and keep on deducting the occurence of each character from
         * the char_map and if you get < 0 then return false or if any block in the char_map is > 0 then return false. 
         * Clarify from the interview what is the domain of characters. If ASCII then 128 is maximum size.
         * If Extended ASCII then 256.
         * Here we will consider the char_map to be of 256 size.
         */

        public bool check_permutation2(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            int[] char_map_a = new int[256];

            for(int i = 0; i < a.Length; i++)
            {
                char_map_a[Convert.ToInt32(a[i])] += 1;
            }

            for(int i = 0; i < b.Length; i++)
            {
                char_map_a[Convert.ToInt32(b[i])] -= 1;
                if (char_map_a[Convert.ToInt32(b[i])] < 0)
                    return false;
            }

            for(int i = 0; i < 256; i++)
            {
                if (char_map_a[i] > 0)
                    return false;
            }

            return true;
        }
    }
}
