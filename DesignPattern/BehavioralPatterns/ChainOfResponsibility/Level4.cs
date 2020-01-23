using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BehavioralPatterns.ChainOfResponsibility
{
    public class Level4 : LogProcessor
    {
        public override LogProcessor NextChain { protected get; set; }

        public override void WriteLog(Log log)
        {
            if (log.LogType == LogType.Error)
            {
                Console.WriteLine("[Log Level4]");
                log.LogId = 1;
            }
            else
            {
                NextChain.WriteLog(log);
            }
        }
    }
}
