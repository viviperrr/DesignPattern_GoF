using System;
using System.Net;
using System.Text;
using VisitorPattern.BasicExample;
using advanced = VisitorPattern.AdvancedExample;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunBasicExample();
            RunAdvancedExample();
        }

        static void RunBasicExample()
        {
            Console.WriteLine("--- Basic Example ---");
            Company company = new Company();
            IVisitor raiseVisitor = new PayRaiseVisitor();
            Console.WriteLine("--- Before evaluation ---");
            company.DisplayData();
            company.Accept(raiseVisitor);
            Console.WriteLine("--- After evaluation ---");
            company.DisplayData();
        }

        static void RunAdvancedExample()
        {
            Console.WriteLine("--- Advanced Example ---");
            advanced.BinaryTree bt = new advanced.BinaryTree(3);
            bt.Root.Left = new advanced.BinaryTreeNode(6);
            bt.Root.Right = new advanced.BinaryTreeNode(9);

            advanced.IVisitor displayVisitor = new advanced.DisplayVisitor();
            advanced.IVisitor addvisitor = new advanced.AddVisitor();
            bt.Traversal(displayVisitor);
            bt.Traversal(addvisitor);
            bt.Traversal(displayVisitor);
        }
    }
}
