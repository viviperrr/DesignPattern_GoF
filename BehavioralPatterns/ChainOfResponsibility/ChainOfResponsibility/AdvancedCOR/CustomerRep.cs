using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AdvancedCOR
{
    public class CustomerRep : ITicketSystem
    {
        private ITicketSystem _next;
        public string Assign(Ticket ticket)
        {
            if (ticket.Difficulty == Difficulty.Low)
            {
                return "Assigned to CustomerRep";
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
