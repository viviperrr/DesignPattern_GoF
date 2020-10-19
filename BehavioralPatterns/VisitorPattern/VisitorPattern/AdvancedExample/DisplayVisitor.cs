using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.AdvancedExample
{
    public class DisplayVisitor : IVisitor
    {
        public void Visit(BinaryTreeNode node)
        {
            if (node.Data % 2 == 0)
            {
                Console.WriteLine(node.Data);
            }
        }
    }
}
