using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BehavioralPatterns.ChainOfResponsibility
{
    public class Level3 : LogProcessor
    {
        public override LogProcessor NextChain { protected get; set; }

        public override void WriteLog(Log log)
        {
            if (log.LogType == LogType.Warning)
            {
                Console.WriteLine("[Log Level3]");
                log.LogId = 1;
            }
            else
            {
                NextChain.WriteLog(log);
            }
        }
    }
}
