using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Model
{
    public class Log
    {
        public int LogId { get; set; }
        public string Message { get; set; }
        public LogType LogType { get; set; }
    }

    public enum LogType
    {
        Trace,
        Info,
        Warning,
        Error
    }
}
