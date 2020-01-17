using DesignPattern.BehavioralPatterns.Iterator;
using DesignPattern.CreationalPatterns.Singleton;
using DesignPattern.Model;
using System;

namespace DesignPatternTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunSingleton();
            RunIterator();
        }

        static void RunSingleton()
        {
            EmailSetting emailSetting = Singleton.Instance["EmailSetting"] as EmailSetting;
        }

        static void RunIterator()
        {
            XCollection coll = new XCollection(); 
            coll.Add("A"); 
            coll.Add("B"); 
            coll.Add("C"); 
            coll.Add("D"); 
            coll.Add("E");

            IXIterator it = coll.GetIterator(); 
            object o;
            // Iterator outputs only the even-numbered data.
            // A C E
            while ((o = it.Next()) != null) 
            { 
                Console.WriteLine(o); 
            }

            coll.Add("F");
            coll.Add("G");
            coll.Add("H");
            Console.WriteLine();
            while ((o = it.Next()) != null)
            {
                Console.WriteLine(o);
            }
        }
    }
}
