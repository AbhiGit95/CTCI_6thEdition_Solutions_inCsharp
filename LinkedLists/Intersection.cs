using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    /*
     * Question : Given two singly linked lists, determine if the two lists intersect. Return the intersecting node. Note : Intersection is defined based on
     * reference, not value. That is, if the kth node of the first linked list is the exact same node(by reference) as the jth node of the second linked list,
     * then they are intersecting.
     */
    class Intersection
    {
        /*
         * Appraoch 1 : Get the length and tail node of both the LinkedLists to confirm if they intersect or not.
         * Then skip the nodes of the larger Linked List by the difference in length of both the linked lists.
         */
        public LinkedList intersecting_node(LinkedList a, LinkedList b)
        {
            LinkedList tail_node_a = null;
            LinkedList tail_node_b = null;
            int len_a = 0; int len_b = 0;

            LinkedList dummy_a = a; LinkedList dummy_b = b;

            while(dummy_a != null)
            {
                tail_node_a = dummy_a;
                dummy_a = dummy_a.get_next();
                len_a++;
            }

            while(dummy_b != null)
            {
                tail_node_b = dummy_b;
                dummy_b = dummy_b.get_next();
                len_b++;
            }

            if (tail_node_a != tail_node_b)
                return null;

            if(len_a == len_b)
            {
                return helper(a, b);
            }

            else if(len_a > len_b)
            {
                int diff = len_a - len_b;
                for(int i = 0; i < diff; i++)
                {
                    a = a.get_next();
                }
                return helper(a, b);
            }

            else
            {
                int diff = len_b - len_a;
                for (int i = 0; i < diff; i++)
                {
                    b = b.get_next();
                }
                return helper(a, b);
            }
        }

        public LinkedList helper(LinkedList a, LinkedList b)
        {
            while (a != null && b != null)
            {
                if (a == b)
                    return a;
                a = a.get_next(); b = b.get_next();
            }

            return null;
        }
    }
}
