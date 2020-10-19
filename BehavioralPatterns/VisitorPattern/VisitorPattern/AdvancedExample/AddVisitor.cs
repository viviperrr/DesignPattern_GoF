using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.AdvancedExample
{
    public class AddVisitor : IVisitor
    {
        public void Visit(BinaryTreeNode node)
        {
            if (node.Data % 3 == 0)
            {
                node.Data += 1;
            }
        }
    }
}
