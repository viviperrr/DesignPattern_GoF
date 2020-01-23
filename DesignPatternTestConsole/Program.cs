using DesignPattern.BehavioralPatterns.ChainOfResponsibility;
using DesignPattern.BehavioralPatterns.Iterator;
using DesignPattern.CreationalPatterns.Singleton;
using DesignPattern.Model;
using DesignPattern.StructuralPatterns.Facade;
using System;

namespace DesignPatternTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunSingleton();
            //RunFacade();
            RunChainOfResponsibility();
            //RunIterator();
        }

        #region Creational
        static void RunSingleton()
        {
            EmailSetting emailSetting = Singleton.Instance["EmailSetting"] as EmailSetting;
        }
        #endregion

        #region Structural
        static void RunFacade()
        {
            Facade facade = new Facade();
            int productId = 1234;
            facade.LoadProductPicture(productId);
        }
        #endregion

        #region Behavioral
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

        static void RunChainOfResponsibility()
        {
            Log log = new Log()
            {
                LogType = LogType.Error,
                Message = "Not Found"
            };

            LogProcessor level1 = new Level1();
            LogProcessor level2 = new Level2();
            LogProcessor level3 = new Level3();
            LogProcessor level4 = new Level4();

            level1.NextChain = level2;
            level2.NextChain = level3;
            level3.NextChain = level4;

            level1.WriteLog(log);
        }
        #endregion
    }
}
