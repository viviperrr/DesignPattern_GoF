using FactoryMethodPattern.Logger;
using System;

namespace FactoryMethodPattern
{
    /// <summary>
    /// Factory Method Pattern
    /// If a Factory pattern determines that an object is created in a single method,
    /// a more generalized Factory Method pattern is a pattern that creates 
    /// the Creator's Base class (or interface) and its subclasses to determine which
    /// objects to create in the subclass.
    /// </summary>
    public abstract class LoggerCreator
    {
        public abstract ILogger Create(string option);
    }

    public class DbLoggerCreator : LoggerCreator
    {
        public override ILogger Create(string conn)
        {
            var logger = new DbLogger();
            logger.ConnectionString = conn;
            
            return logger;
        }
    }

    public class FileLoggerCreator : LoggerCreator
    {
        public override ILogger Create(string fileName)
        {
            if (fileName.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
            {
                return new XmlLogger();
            }
            else if (fileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            {
                return new JsonLogger();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
