using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    /*
     * Question - Implement a method to perform basic string compression using the counts of repeated characters. If the compressed string would not become smaller
     * than the original string, your method should return the original string.
     */
    class StringCompression
    {
        public string compressedstring(string s)
        {
            if (s.Length == 1)
                return s;

            StringBuilder sb = new StringBuilder();
            int count = 1;
            for(int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                    count++;
                else
                {
                    sb.Append(s[i - 1]);
                    sb.Append(count);
                    count = 1;
                }
            }

            //Add the last character
             sb.Append(s[s.Length - 1]);
             sb.Append(count);
            

            var res = sb.ToString();

            return res.Length < s.Length ? res : s;
        }
    }
}
