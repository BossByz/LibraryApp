using System;
using System.Collections.Generic;
using System.Linq;

namespace POE_APP
{

    /*
     * CODE ATTRIBUTION: https://stackoverflow.com/questions/30982128/how-to-organaze-data-in-a-tree-like-structure
     */

    //TREENODE CLASS
    public class TreeNode<T>
    {
        //GLOBAL PROPERTIES
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }
        public TreeNode<T> Parent { get; set; }

        //CONSTRUCTOR
        public TreeNode()
        {
            Children = new List<TreeNode<T>>();
        }

        //SECOND CONSTRUCTOR
        public TreeNode(T val) : this()
        {
            Value = val;
        }

        //INDEXER
        public TreeNode<T> this[int i]
        {
            get => Children[i];
            set => Children[i] = value;
        }

        //ADDNODE METHOD
        public TreeNode<T> AddNode(TreeNode<T> parent, T val)
        {
            //CREATE A NEW NODE AND SET THE PARENT
            TreeNode<T> child = new TreeNode<T>(val);
            child.Parent = parent;
            parent.Children.Add(child);
            return child;
        }
    }
}
