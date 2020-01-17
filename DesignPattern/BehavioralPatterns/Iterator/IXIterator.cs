using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BehavioralPatterns.Iterator
{
    public interface IXIterator
    {
        object Current();
        object Next();
    }

    public class XIterator : IXIterator
    {
        private XCollection collection;
        public int Position { get; private set; }
        public XIterator(XCollection xCollection)
        {
            Position = 0;
            collection = xCollection;
        }

        public object Current()
        {
            return collection[Position];
        }

        public object Next()
        {
            object data;

            if (collection.Count <= Position)
            {
                Position = 0;
                return null;
            }
            data = Current();
            Position += 2;
            return data;
        }
    }
}
