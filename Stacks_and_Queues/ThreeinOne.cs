using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues
{
    /*
     * Question : Describe how could you use a single array to implement three stacks.
     */
    class ThreeinOne
    {
        //Appraoch 1 : Fixed Division

        private int num_of_stacks = 3;
        private int stack_Capacity;
        private int[] values; // This array will store all the values across three stacks in a linear manner.
        private int[] indices; //This array will set the index of each stack where the current element has to be pushed/popped.

        public ThreeinOne(int stack_size)
        {
            stack_Capacity = stack_size;
            values = new int[stack_size * num_of_stacks];
            indices = new int[num_of_stacks];
        }

        public void Push(int stacknum, int val)
        {
            if (isFull(stacknum))
                Console.WriteLine("The Stack {0} is full", stacknum);

            else
            {
                values[indices[stacknum]] = val;
                indices[stacknum]++;
            }
        }

        public int Pop(int stacknum)
        {

        }

        public int Peek(int stacknum)
        {

        }

        public bool isEmpty(int stacknum)
        {
            return indices[stacknum] == 0;
        }

        public bool isFull(int stacknum)
        {
            return indices[stacknum] == stack_Capacity;
        }
    }
}
