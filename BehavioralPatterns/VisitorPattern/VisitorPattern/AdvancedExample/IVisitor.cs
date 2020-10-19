using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.AdvancedExample
{
    public interface IVisitor
    {
        public void Visit(BinaryTreeNode node);
    }
}
