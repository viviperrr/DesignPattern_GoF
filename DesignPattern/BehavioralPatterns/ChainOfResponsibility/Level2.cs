using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BehavioralPatterns.ChainOfResponsibility
{
    public class Level2 : LogProcessor
    {
        public override LogProcessor NextChain { protected get; set; }

        public override void WriteLog(Log log)
        {
            if (log.LogType == LogType.Info)
            {
                Console.WriteLine("[Log Level2]");
                log.LogId = 1;
            }
            else
            {
                NextChain.WriteLog(log);
            }
        }
    }
}
