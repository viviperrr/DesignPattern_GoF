using FactoryMethodPattern.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    /// <summary>
    /// Factory Pattern
    /// </summary>
    public class LoggerFactory
    {
        public ILogger Create(string option)
        {
            switch (option)
            {
                case "DB": return new DbLogger();
                case "XML": return new XmlLogger();
                case "JSON": return new JsonLogger();
                default: throw new InvalidOperationException();
            }
        }
    }
}
