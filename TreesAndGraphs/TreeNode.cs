using System;
using System.Collections.Generic;
using System.Text;

namespace TreesAndGraphs
{
    class TreeNode
    {
        int _val;
        TreeNode _left;
        TreeNode _right;

        public TreeNode(int val)
        {
            this._val = val;
        }

        public void set_left(TreeNode node)
        {
            this._left = node;
        }

        public void set_right(TreeNode node)
        {
            this._right = node;
        }

        public TreeNode get_left()
        {
            return this._left;
        }

        public TreeNode getright()
        {
            return this._right;
        }

        public int getval()
        {
            return this._val;
        }
    }
}
