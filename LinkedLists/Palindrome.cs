using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{ 
    /*
     * Question : Write a function to check if a linked list is a palindrome.
    */
    class Palindrome
    {
        //Approach 1 : Append each value of the node and convert it into string and check with reverse of string.

        public bool llist_palindorme(LinkedList head)
        {
            StringBuilder sb = new StringBuilder();

            while(head != null)
            {
                sb.Append(head.get_val());
                head = head.get_next();
            }

            string a = sb.ToString();
            int start = 0; int end = a.Length - 1;
            while(start <= end)
            {
                if (a[start] != a[end])
                    return false;

                start++; end--;

            }

            return true;
        }
    }
}
