using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AdvancedSingleton.Instance.PrintKeyAndValue();
            Console.WriteLine(AdvancedSingleton.Instance["Username"]);
        }
    }
}
