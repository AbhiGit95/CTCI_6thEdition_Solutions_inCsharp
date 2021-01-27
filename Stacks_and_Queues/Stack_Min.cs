using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues
{
    /*
     *  How would you design a stack which, in addition to push and pop, has a function min which returns the minimum element? Push, Pop and min should all operate
     *  in O(1) time.
     *  Solution : We will use two stacks. One stack for storing the integers. Another to store the minimums at every changing state.
     */
    class Stack_Min
    {
        Stack<int> stack1;
        Stack<int> min_stack;
        public Stack_Min()
        {
            stack1 = new Stack<int>();
            min_stack = new Stack<int>();
        }

        public void Push(int x)
        {
            if(x <= min_elem())
            {
                min_stack.Push(x);
            }

            stack1.Push(x);
        }

        public int Pop()
        {
            if(stack1.Count > 0)
            {
                int val = stack1.Pop();
                if (val == min_elem())
                    min_stack.Pop();

                return val;
            }
            else
            {
                return -1;
            }
        }

        public int min_elem()
        {
            if (min_stack.Count > 0)
                return min_stack.Peek();
            else
                return int.MaxValue;
        }
    }
}
