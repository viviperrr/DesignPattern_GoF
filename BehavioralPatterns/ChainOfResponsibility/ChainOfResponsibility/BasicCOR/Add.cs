using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.BasicCOR
{
    public class Add : ICalcChain
    {
        private ICalcChain _next;

        public int Calculate(ICalcType ctype, int a, int b)
        {
            if (ctype == ICalcType.Add)
            {
                return a + b;
            }
            else
            {
                return this._next.Calculate(ctype, a, b);
            }
        }

        public void NextChain(ICalcChain next)
        {
            this._next = next;
        }
    }
}
