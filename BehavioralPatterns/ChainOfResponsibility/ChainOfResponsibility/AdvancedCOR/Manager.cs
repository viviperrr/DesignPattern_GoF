using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AdvancedCOR
{
    public class Manager : ITicketSystem
    {
        private ITicketSystem _next;
        public string Assign(Ticket ticket)
        {
            if (ticket.Difficulty == Difficulty.Medium)
            {
                return "Assigned to Manager";
            }
            else
            {
                return this._next.Assign(ticket);
            }
        }

        public void NextChain(ITicketSystem next)
        {
            this._next = next;
        }
    }
}
