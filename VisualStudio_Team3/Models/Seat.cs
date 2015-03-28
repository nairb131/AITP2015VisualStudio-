using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_Team3.Models
{
    public class Seat
    {
        public int SeatNo { get; set; }
        public string SeatLocation { get; set; }
        public bool Reserved { get; set; }
        public decimal SeatPrice { get; set; }
    }
}
