using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BehavioralPatterns.Iterator
{
    public interface IXCollection
    {
        IXIterator GetIterator();
    }

    public class XCollection : IXCollection
    {
        private List<object> collection;
        public int Count { get { return collection.Count; } }   
        public XCollection()
        {
            collection = new List<object>();
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return collection[index];
            }
        }

        public IXIterator GetIterator()
        {
            return new XIterator(this);
        }

        public void Add(object obj)
        {
            collection.Add(obj);
        }
    }
}
