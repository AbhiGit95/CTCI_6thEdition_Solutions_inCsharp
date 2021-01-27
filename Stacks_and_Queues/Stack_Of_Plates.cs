using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues
{
    /*
     * Question : Imagine a stack of plates. If the stack gets too high, it might topple. Therefore, in real life, we would likely to start a new stack when the
     * previous stack exceeds some threshold. Implement a data structure SetOfStacks that mimics this. SetOfStacks should be composed of several stacks and should
     * create a new Stack once the previous one exceeds capacity. SetOfStacks.Push() and SetOfStacks.Pop() should behave identically to a single stack (that is,
     * pop() should return the same values as it would if there were just a single stack.)
     * 
     * Follow up : Impelement a function popAt(int index) which performs a pop operation on a specific sub-stack.
     */
    class Stack_Of_Plates
    {
        List<Stack<int>> list_of_stacks;
        int threshold;
        int capacity;
        public Stack_Of_Plates(int thresh)
        {
            this.threshold = thresh;
            list_of_stacks = new List<Stack<int>>();
            capacity = 0;
        }

        public void Push(int x)
        {
            if (list_of_stacks.Count == 0)
            {
                Stack<int> first = new Stack<int>();
                first.Push(x);
                capacity += 1;
                list_of_stacks.Add(first);
            }
            else
            {
                if (capacity == threshold)
                {
                    Stack<int> reload = new Stack<int>();
                    reload.Push(x);
                    capacity = 1;
                    list_of_stacks.Add(reload);
                }

                else
                {
                    list_of_stacks[list_of_stacks.Count - 1].Push(x);
                    capacity += 1;
                }
            }
        }

        public int Pop()
        {
            if (list_of_stacks.Count == 0)
                return -1;

            else
            {
                if(capacity == 0)
                {
                    list_of_stacks.RemoveAt(list_of_stacks.Count - 1);
                    capacity = threshold - 1;
                    return list_of_stacks[list_of_stacks.Count - 1].Pop();
                }
                else
                {
                    capacity -= 1;
                    return list_of_stacks[list_of_stacks.Count - 1].Pop();
                }
            }
        }
    }
}
