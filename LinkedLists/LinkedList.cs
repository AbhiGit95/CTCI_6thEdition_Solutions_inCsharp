using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    class LinkedList
    {
        int _val;
        LinkedList _next;
        public LinkedList(int value, LinkedList node)
        {
            this._val = value;
            if (node != null)
                this._next = node;

            else
                this._next = null;
        }

        public int get_val()
        {
            return this._val;
        }

        public void set_val(int a)
        {
            this._val = a;
        }

        public LinkedList get_next()
        {
            return this._next;
        }

        public void set_next(LinkedList node)
        {
            this._next = node;
        }
    }
}
