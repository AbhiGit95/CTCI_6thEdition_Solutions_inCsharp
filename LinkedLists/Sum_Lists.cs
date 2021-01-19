using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{ 
    /*
     * Question : You have two numbers represented by a linked list, where each node contains a single digit. The digits are stored in reverse order, 
     * such that the 1's digit is at the head of the list. Write a function that adds the two numbers and returns the sum as a linked list.
     * (Do not convert the linked list to an integer for the ease of addition).
     */
    class Sum_Lists
    {
        public LinkedList sum_lists(LinkedList a, LinkedList b)
        {
            int carry = 0;

            LinkedList head = null;
            LinkedList dummy = null;
            while(a != null && b != null)
            {
                int sum = a.get_val() + b.get_val();
                if (dummy == null)
                {
                    carry = sum / 10;
                    dummy = new LinkedList(sum % 110, null);
                    head = dummy;
                }

                else
                {
                    sum += carry;
                    carry = sum / 10;
                    dummy.set_next(new LinkedList(sum % 10, null));
                    dummy = dummy.get_next();
                }
                a = a.get_next(); b = b.get_next();
            }

            if(a == null)
            {
                while( b != null)
                {
                    int sum = b.get_val() + carry;
                    carry = sum / 10;
                    dummy.set_next(new LinkedList(sum % 10, null));
                    dummy = dummy.get_next();
                }

                b = b.get_next();
            }

            else if( b == null)
            {
                while (a != null)
                {
                    int sum = a.get_val() + carry;
                    carry = sum / 10;
                    dummy.set_next(new LinkedList(sum % 10, null));
                    dummy = dummy.get_next();
                }
            }

            if(carry != 0)
            {
                dummy.set_next(new LinkedList(carry, null));
            }

            return head;
        }
    }
}
