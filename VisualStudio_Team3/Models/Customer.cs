using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace VisualStudio_Team3.Models
{
    public class Customer
    {
        public int CustomerID { get; private set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZCode { get; set; }
        public string Email { get; set; }
        public string CustomerType { get; set; }
        public int PurchaseID { get; set; }
        public int TicketsID { get; set; }
    }
}
