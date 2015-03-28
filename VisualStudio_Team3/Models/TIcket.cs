using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_Team3.Models
{
    public class Ticket
    {
        public int TicketsID { get; }
        public string TicketType { get; set; }
        public int BeginSeat { get; set; }
        public int EndSeat { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
