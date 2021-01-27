using System;
using System.Collections.Generic;
using System.Text;


namespace TreesAndGraphs
{
    /*
     * Question : Given a binary tree, design an algorithm which creates a linked list of all the nodes at each depth (e.g., if you have a tree
     * with depth D, you will have D linked lists.)
     * 
     * Solution : Performing BFS to do a level order traversal.
     */
    class ListOfDepths
    {
        public List<Linked_Lists.LinkedList> listoflevels(TreeNode root)
        {
            if (root == null)
                return null;

            Queue<TreeNode> bfs_queue = new Queue<TreeNode>(); //Initialize a queue for FIFO
            TreeNode dummy = new TreeNode(-1); //Dummy node to mark the end of each level
            bfs_queue.Enqueue(root); // enqueue the root 
            bfs_queue.Enqueue(dummy); // then dummy node because root is a single node on first level
            List<Linked_Lists.LinkedList> res = new List<Linked_Lists.LinkedList>(); // data structure for holding the linked lists

            Linked_Lists.LinkedList head = null; //intialize head to null
            Linked_Lists.LinkedList current = null; // current will basically add to the linked list
            while (bfs_queue.Count > 0) // while there are elements to be processed in the queue.
            {
                TreeNode node = bfs_queue.Dequeue(); // Get the treenode
                if (node == dummy && bfs_queue.Count > 0) // check if it's a dummy and there are nodes in the queue after it.
                {
                    bfs_queue.Enqueue(dummy);  // Add the dummy node back to mark the end of level.
                    res.Add(head);  // This means a level has finished so add the head.
                    head = null; // Set head = null 
                    current = null; // Set current = null
                }

                else if(node == dummy && bfs_queue.Count == 0) // if current node is dummy means we have ended a level and no more nodes are present in the queue.
                {
                    res.Add(head); //Add the last linked list in the result list.
                    break;
                }

                else
                {
                    if (head == null) // check if the linked list has been initialized.
                    {
                        head = new Linked_Lists.LinkedList(node.getval(), null); // initialize head
                        current = head; // point current to head
                    }
                    else
                    {
                        current.set_next(new Linked_Lists.LinkedList(node.getval(), null)); // set the next node for the current LinkedList
                        current = current.get_next(); // move current to next
                    }

                    if (node.get_left() != null)
                        bfs_queue.Enqueue(node.get_left()); // check if left child exists then add

                    if (node.getright() != null)
                        bfs_queue.Enqueue(node.getright()); // check if right child exists then add
                }
            }

            return res; //return the list
        }
    }
}
