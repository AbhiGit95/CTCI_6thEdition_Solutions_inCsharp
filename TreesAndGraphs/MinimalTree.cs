using System;
using System.Collections.Generic;
using System.Text;

namespace TreesAndGraphs
{
    /*
     * Question : Given a sorted(increasing order) array with unique integer elements, write an algorithm to create a binary search tree
     * with minimal height.
     * 
     * Solution : The root will be the middle element of the array and then recursively build the tree on the subpartitions.
     */

    class MinimalTree
    {
        public TreeNode binarytree(int[] arr)
        {
            int n = arr.Length;

            if (arr == null || n == 0)
                return null;

            return helper(arr, 0, n - 1);
            
        }
      
        public TreeNode helper(int[] arr, int start, int end)
        {
            if (start > end)
                return null;

            int mid = ((end - start) / 2) + start;
            TreeNode root = new TreeNode(arr[mid]);
            root.set_left(helper(arr, start, mid - 1));
            root.set_right(helper(arr, mid + 1, end));
            return root;
        }
    }

  }

