using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VisualStudio_Team3.Models
{
    public class Seat
    {

        public int SeatNo { get; private set; }
        public string SeatLocation { get; private set; }
        [Required]
        public bool Reserved { get; set; }
        public decimal SeatPrice { get; private set; }
    }
}
