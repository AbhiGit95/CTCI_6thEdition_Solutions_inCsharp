using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues
{
    /*
     * Question : Write a program to sort a stack such that the smallest items are on the top. You can use an additional temporary stack, but you may not copy
     * the elements into any other data structure (such as an array). The stack supports the following operations : push, pop, peek and isEmpty.
     */
    class SortStack
    {

        public void sort_stack(Stack<int> stack)
        {
            Stack<int> temp = new Stack<int>(); // This stack will contain the elements in reverse sorted order [max on top and min at bottom].

            while(stack.Count > 0)
            {
                int val = stack.Pop(); 
                while(temp.Count > 0 && temp.Peek() > val) // Pop out all elements from temp which are greater than val and store them in original stack.
                {
                    stack.Push(temp.Pop());
                }

                temp.Push(val); // insert the element val at it's correct place according to the order
            }

            //After this while loop the temp stack contains all the elements from original stack in reverse sorted order. Now just copy back. 

            while(stack.Count > 0 )
            {
                stack.Push(temp.Pop());
            }

            //end of function
        }
    }
}
