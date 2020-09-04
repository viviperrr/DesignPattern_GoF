using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// The Singleton allows a class to have only one instance.
    /// A pattern that gives access to an instacne in the Global Scope.
    /// </summary>
    public sealed class BasicSingleton
    {
        /// <summary>
        /// static readonly instacne: Unchangeable global instance.
        /// </summary>
        public static readonly BasicSingleton instantce = new BasicSingleton();

        /// <summary>
        /// Private Constructor: Avoid objectification from the outside.
        /// </summary>
        private BasicSingleton() { /* ... */ }
    }
}
