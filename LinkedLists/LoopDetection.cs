using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    /*
     * Question : Given a Linked List which might contain a loop, implement an algorithm that returns the node at the beginning of the loop. (if one exists).
     */
    class LoopDetection
    {
        public LinkedList loopdetector(LinkedList head)
        {

            LinkedList slow = head;
            LinkedList fast = head;

            while(fast != null && fast.get_next() != null)
            {
                slow = slow.get_next();
                fast = fast.get_next().get_next();

                if (slow == fast)
                    break;
            }

            //check if loop exists
            if (fast == null || fast.get_next() == null)
                return null;

            slow = head;
            while(slow != fast)
            {
                slow = slow.get_next();
                fast = fast.get_next();
            }

            return slow;
        }
    }
}
