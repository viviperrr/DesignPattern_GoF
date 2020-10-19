using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.BasicCOR
{
    public interface ICalcChain
    {
        public void NextChain(ICalcChain next);
        public int Calculate(ICalcType ctype, int a, int b);
    }

    public enum ICalcType
    {
        Add,
        Substract,
        Multiply,
        Divide
    }
}
