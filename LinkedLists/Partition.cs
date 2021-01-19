using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    /*
     * Question : Write code to partition a linked list around a value x, such that all nodes less than x come before all nodes greater than or equal to x.
     * (Note : The partition element x can appear anywhere in the right partition, it doesnt need to appear between the left and right partitions.
     */
    class Partition
    {
        /*
         * We can create two linkedlists, one which contains the values < x and the other which contains the values > x
         */
        public LinkedList partition_list(LinkedList head, int target)
        {
            LinkedList smaller_start = null;
            LinkedList smaller_end = null;
            LinkedList greater_start = null;
            LinkedList greater_end = null;

            while(head != null)
            {
                int val = head.get_val();

                if(val < target)
                {
                    if(smaller_start == null)
                    {
                        smaller_start = head;
                        smaller_end = smaller_start;
                     }
                    else
                    {
                        smaller_end.set_next(head);
                        smaller_end = head;
                    }
                }
                else
                {
                    if(greater_start == null)
                    {
                        greater_start = head;
                        greater_end = greater_start;
                    }
                    else
                    {
                        greater_end.set_next(head);
                        greater_end = head;
                    }
                }

                head = head.get_next();
            }

            //check if before list is empty or not

            if (smaller_start == null)
                return greater_start;

            smaller_end.set_next(greater_start);
            return smaller_start;

        }
    }
}
