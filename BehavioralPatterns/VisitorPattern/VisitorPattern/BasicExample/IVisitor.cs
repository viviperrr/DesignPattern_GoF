using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.BasicExample
{
    public interface IVisitor
    {
        void Visit(Employee emp);
    }

    public class PayRaiseVisitor : IVisitor
    {
        public void Visit(Employee emp)
        {
            int raise = 0;

            if (emp.Score >= 90)
            {
                raise = 1000;
            }
            else if (emp.Score >= 80)
            {
                raise = 800;
            }
            else if (emp.Score >= 70)
            {
                raise = 600;
            }

            emp.Salary += raise;
        }
    }
}
