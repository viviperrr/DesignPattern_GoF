using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AdvancedCOR
{
    public class VicePresident : ITicketSystem
    {
        private ITicketSystem _next;
        public string Assign(Ticket ticket)
        {
            if (ticket.Difficulty == Difficulty.VeryHigh)
            {
                return "Assigned to Vice President";
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
