using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    /*
     * Question - Implement an algorithm to delete a node in the middle (i.e. any node but first and last node, not necessarily the exact middle) of 
     * a singly linked list, given only access to that node.
     * Ask the interviewer if it just means deleting the node by value or not. And also the nodes have unique values or not. 
     */
    class Delete_Middle_Node
    {

        public void delete_mid_node(LinkedList node)
        {
            int temp = node.get_next().get_val(); // store the value of the next node.
            node.set_val(temp); // Set the value of the current node with the value obtained in previous step.
            node.set_next(node.get_next().get_next()); // make the current node to point to the next node of the current's next.
        }

    }
}
