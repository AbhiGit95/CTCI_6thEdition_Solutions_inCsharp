using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues
{
    /*
     * Question : Implement a Queue class which implements a queue using two stacks.
     */
    class Queue_via_stacks
    {
        Stack<int> front;
        Stack<int> back;

        public Queue_via_stacks()
        {
            front = new Stack<int>();
            back = new Stack<int>();
        }

        public void Enqueue(int x)
        {
            back.Push(x);
        }

        public int Dequeue()
        {
            if(front.Count == 0)
            {
                load_into_stack();
            }

            return front.Pop();
        }

        public int Peek()
        {
            if (front.Count == 0)
            {
                load_into_stack();
            }
            return front.Peek();
        }

        public void load_into_stack()
        {
            while (back.Count > 0)
            {
                front.Push(back.Pop());
            }
        }

        public int Count()
        {
            return front.Count + back.Count;
        }
    }
}
