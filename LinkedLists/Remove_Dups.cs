using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    /*
     * Question : Write a method to remove all duplicates from an unsorted list. Follow up : Can you do it without using extra buffer?
     * Ask interviewer if duplicate means just the value or the node itself. 
     */
    class Remove_Dups
    {
        /*
         * T(n) = O(n) : Single Pass. Keep a previous pointer and a current pointer. Whenever you find a duplicate point the previous's next to current's next.
         */
        public LinkedList remove_duplicate(LinkedList head)
        {
            HashSet<int> set = new HashSet<int>();

            LinkedList temp = head;
            LinkedList prev = null;

            while(temp != null)
            {
                if(!set.Contains(temp.get_val()))
                {
                    set.Add(temp.get_val());
                    prev = temp;
                }
                else
                {
                    prev.set_next(temp.get_next());
                }

                temp = temp.get_next();
            }

            return head;
        }
    }
}
