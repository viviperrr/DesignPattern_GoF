using ChainOfResponsibility.AdvancedCOR;
using ChainOfResponsibility.BasicCOR;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            RunBasicCOR();
            RunAdvancedCOR();
        }

        static void RunBasicCOR()
        {
            ICalcChain add = new Add();
            ICalcChain sub = new Substract();
            ICalcChain mul = new Multiply();
            ICalcChain div = new Divide();

            add.NextChain(sub);
            sub.NextChain(mul);
            mul.NextChain(div);

            Console.WriteLine("------ Running Basic COR ------");
            Console.WriteLine($"6 + 3 = {add.Calculate(ICalcType.Add, 6, 3)}");
            Console.WriteLine($"6 - 3 = {add.Calculate(ICalcType.Substract, 6, 3)}");
            Console.WriteLine($"6 * 3 = {add.Calculate(ICalcType.Multiply, 6, 3)}");
            Console.WriteLine($"6 / 3 = {add.Calculate(ICalcType.Divide, 6, 3)}");
        }

        static void RunAdvancedCOR()
        {
            ITicketSystem customerRep = new CustomerRep();
            ITicketSystem manager = new Manager();
            ITicketSystem generalManager = new GeneralManager();
            ITicketSystem vicePresident = new VicePresident();

            customerRep.NextChain(manager);
            manager.NextChain(generalManager);
            generalManager.NextChain(vicePresident);

            Ticket ticket = new Ticket()
            {
                Id = 1,
                Difficulty = Difficulty.Low,
                Issue = "An use cannot login",
                Name = "Failure to login"
            };

            Console.WriteLine("------ Running Advanced COR ------");
            Console.WriteLine($"{ticket} || Assigned To: {customerRep.Assign(ticket)}");
            ticket.Difficulty = Difficulty.Medium;
            Console.WriteLine($"{ticket} || Assigned To: {customerRep.Assign(ticket)}");
            ticket.Difficulty = Difficulty.High;
            Console.WriteLine($"{ticket} || Assigned To: {customerRep.Assign(ticket)}");
            ticket.Difficulty = Difficulty.VeryHigh;
            Console.WriteLine($"{ticket} || Assigned To: {customerRep.Assign(ticket)}");
        }
    }
}
