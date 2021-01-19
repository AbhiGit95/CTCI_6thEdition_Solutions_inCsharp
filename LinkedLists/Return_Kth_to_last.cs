using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    /*
     * Question : Implement an algorithm to find the kth to last element of a singly linked list.
     */
    class Return_Kth_to_last
    {
        // Two Pointer approach.
        public int kth_tolast(LinkedList head, int k)
        {
            LinkedList p1 = head;
            LinkedList p2 = head;

            for(int i =0; i < k; i++)
            {
                if (p1 == null)
                    return -1; // k is greater than the length of the linkedlist

                p1 = p1.get_next();
            }

            while(p1 != null)
            {
                p1 = p1.get_next();
                p2 = p2.get_next();
            }

            return p2.get_val();
        }
    }
}
