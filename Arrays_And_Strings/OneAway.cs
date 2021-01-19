using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    /*
     * Question - Write a method to check if given two strings are one edit or zero edits away.
     */
    class OneAway
    {
        public bool one_edit(string a, string b)
        {
            if (Math.Abs(a.Length - b.Length) > 1)
                return false;

            else if (a.Length == b.Length && a.Equals(b))
                return true;
            
            else if(a.Length == b.Length)
            {
                //make call to the function checking for equal strings.
                return equallen(a, b);
            }

            else
            {
                //make call to the function checking for possible one edit away.
                return a.Length > b.Length ? unequallen(b, a) : unequallen(a, b);
            }
        }

        public bool equallen(string a, string b)
        {
            bool edit = false;

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i] && edit)
                    return false;
                else if (a[i] != b[i])
                    edit = true;
            }
            return true;
        }

        public bool unequallen(string small, string large)
        {
            bool edit = false;
            int i = 0; int j = 0;
            while(i < small.Length && j < large.Length)
            {
                if (small[i] != large[j] && edit)
                    return false;
                else if(small[i] != large[j])
                {
                    edit = true;
                    j++;
                }
                else
                {
                    i++; j++;
                }
            }

            return true;
        }
    }
}
