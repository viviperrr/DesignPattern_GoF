using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.AdvancedExample
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode(int data)
        {
            this.Data = data;
        }

        public int Data { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
    }
}
