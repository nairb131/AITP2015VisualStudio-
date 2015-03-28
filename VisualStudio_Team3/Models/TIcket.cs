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
        public int TicketsID { get; }
        [Required]
        [TicketTypeAttribute]
        public string TicketType { get; set; }
        [Required]
        public int BeginSeat { get; set; }
        [Required]
        public int EndSeat { get; set; }
        public decimal TicketPrice { get; }
        [Required]
        public int Quantity { get; set; }
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
