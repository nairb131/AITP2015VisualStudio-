using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_Team3.Models
{
    public class Ticket
    {
        //no base constructor, seat must have a price
        public Ticket(decimal seatPrice)
        {
            Quantity = this.EndSeat - this.BeginSeat;
            TicketPrice = seatPrice * this.Quantity;            
        }

        public int TicketsID { get; private set; }
        [Required]
        [TicketTypeAttribute]
        public string TicketType { get; set; }
        [Required]
        public int BeginSeat { get; set; }        
        public int EndSeat { get; set; }
        //in code setter for this
        [Required]
        public decimal TicketPrice { get; set; } 
        [Required]
        public int Quantity { get; private set; }        
    }

    //check if value entered is ok
    //Group or Reserved only
    public sealed class TicketTypeAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var val = value.ToString();
            if (val != "Group" && val != "Reserved")
            {
                ErrorMessage = string.Format("Not a valid type");
                return false;
            }
            return true;
        }
    }
}
