using System;
using System.Collections.Generic;
using System.Text;

namespace TreesAndGraphs
{
    /*
     * Question : Given a directed graph and two nodes (S and E), design an algorithm to find out whether there is a route from S to E.
     * Solution : Do a BFS from S and see if we reach E or not.
     */
    class RouteBetweenNodes
    {
        /*
         * The nodes are unique integer values. We are given the list of nodes and their edges in form of a Dictionary of nodes and list.
         */
        public bool routeExists(Dictionary<int,List<int>> adj_list, int source, int destination)
        {
            Queue<int> nodes = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            nodes.Enqueue(source);
            visited.Add(source);
            while(nodes.Count > 0)
            {
                int current_node = nodes.Dequeue();
                foreach(int n in adj_list[current_node])
                {
                    if (n == destination)
                        return true;

                    if(!visited.Contains(n))
                    {
                        nodes.Enqueue(n);
                        visited.Add(n);
                    }
                }
            }

            return false;
        }

        
    }
}
