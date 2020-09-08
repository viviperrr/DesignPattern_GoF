using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Logger
{
    public interface ILogger 
    {
        public void GetLoggerType();
    }

    public class DbLogger : ILogger
    {
        public string ConnectionString { get; set; }
        public void GetLoggerType()
        {
            Console.WriteLine("DB");
        }
    }
    public class XmlLogger : ILogger
    {
        public void GetLoggerType()
        {
            Console.WriteLine("Xml");
        }
    }
    public class JsonLogger : ILogger
    {
        public void GetLoggerType()
        {
            Console.WriteLine("Json");
        }
    }
}
