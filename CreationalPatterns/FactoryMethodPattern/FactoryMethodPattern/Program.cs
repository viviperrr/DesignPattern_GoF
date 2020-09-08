using FactoryMethodPattern.Logger;
using System;
using System.Collections.Generic;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFactoryPattern();
            RunFactoryMethodPattern();
        }

        static void RunFactoryPattern()
        {
            List<ILogger> loggers = new List<ILogger>();
            var xmlLog = new LoggerFactory();
            loggers.Add(xmlLog.Create("DB"));
            loggers.Add(xmlLog.Create("XML"));
            loggers.Add(xmlLog.Create("JSON"));

            foreach (var l in loggers)
            {
                l.GetLoggerType();
            }
        }

        static void RunFactoryMethodPattern()
        {
            List<ILogger> loggers = new List<ILogger>();
            loggers.Add(new FileLoggerCreator().Create("log.json"));
            loggers.Add(new FileLoggerCreator().Create("log.xml"));
            loggers.Add(new DbLoggerCreator().Create("Data Source=Path;Initial Catalog=MyDB;User ID=sa;Password=****"));

            foreach (var l in loggers)
            {
                l.GetLoggerType();
            }
        }
    }
}
