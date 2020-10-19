using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace VisitorPattern.AdvancedExample
{
    public class BinaryTree
    {
        public BinaryTreeNode Root { get; private set; }
        public BinaryTree(int data)
        {
            Root = new BinaryTreeNode(data);
        }

        public void Traversal(IVisitor visitor)
        {
            traversal(this.Root, visitor);
            if (visitor is DisplayVisitor)
            {
                Console.WriteLine(" Traversal End ");
            }
        }

        private void traversal(BinaryTreeNode node, IVisitor visitor)
        {
            if (node == null)
            {
                return;
            }

            traversal(node.Left, visitor);
            visitor.Visit(node);
            traversal(node.Right, visitor);
        }
    }
}
