using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BehavioralPatterns.ChainOfResponsibility
{
    public abstract class LogProcessor
    {
        public abstract LogProcessor NextChain { protected get; set; }
        public abstract void WriteLog(Log log);
    }
}
