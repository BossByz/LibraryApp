using System;
using System.Collections.Generic;
using System.Linq;

namespace POE_APP
{

    /*
     * CODE ATTRIBUTION: https://stackoverflow.com/questions/30982128/how-to-organaze-data-in-a-tree-like-structure
     */

    //TREE CLASS
    public class Tree<T>
    {
        //GLOBAL VARIABLES
        public List<TreeNode<T>> Nodes { get; set; }

        //CONSTRUCTOR
        public Tree()
        {
            Nodes = new List<TreeNode<T>>();
        }

        //ADDNODE METHOD
        public TreeNode<T> AddNode(T val)
        {
            //CREATE A NEW NODE
            TreeNode<T> child = new TreeNode<T>(val);
            Nodes.Add(child);
            return child;
        }
    }
}