using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    /*
     * Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end to hold the additional
     * characters, and that you are given the "true" length of the string. (Assume the given string is in character array to do it in place.)
     */
    class URLify
    {
        public string urlifystring(char[] s, int truelength)
        {
            int no_spaces = find_spaces(s, 0, truelength, ' ');
            int new_index = (truelength - 1) + (no_spaces * 2);

            //If extra space is given then mark it with null character.
            if (new_index + 1 < s.Length)
                s[new_index + 1] = '\0';

            for(int old_index = truelength -1; old_index >= 0; old_index--)
            {
                if(s[old_index] == ' ')
                {
                    s[new_index] = '0';
                    s[new_index - 1] = '2';
                    s[new_index - 2] = '%';
                    new_index -= 3;
                }
                else
                {
                    s[new_index] = s[old_index];
                    new_index -= 1;
                }
            }

            return s.ToString();
        }

        public int find_spaces(char[]s, int start, int end, int target)
        {
            int count = 0;
            while(start <= end)
            {
                if (s[start] == ' ')
                    count++;

                start++;
            }

            return count;
        }

        /*
         * Method 2 - Here the assumption is we need to replace the spaces only between the strings or characters. Any space after the end of the string
         * wil not be converted.
         */

        public string urlify_method2(string s, int truelength)
        {
            string[] arr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();

            int n = arr.Length;

            for(int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]);
                if(i != n-1)
                {
                    sb.Append("%20");
                }
            }

            return sb.ToString();
        }
    }
}
