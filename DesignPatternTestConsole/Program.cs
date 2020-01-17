using DesignPattern.CreationalPatterns;
using DesignPattern.Model;
using System;

namespace DesignPatternTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSingleton();
        }

        static void RunSingleton()
        {
            EmailSetting emailSetting = Singleton.Instance["EmailSetting"] as EmailSetting;
        }
    }
}
