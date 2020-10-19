using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AdvancedCOR
{
    public interface ITicketSystem
    {
        public void NextChain(ITicketSystem next);
        public string Assign(Ticket ticket);
    }

    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Issue { get; set; }
        public Difficulty Difficulty { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Issue: {Issue} Difficulty: {Difficulty.ToString("g")}";
        }
    }

    public enum Difficulty
    {
        Low,
        Medium,
        High,
        VeryHigh
    }
}
