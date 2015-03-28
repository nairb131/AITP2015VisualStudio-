using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VisualStudio_Team3.Models
{
    public class Customer
    {
        
        public int CustomerID { get; private set; }
        [Required]
        [MaxLength(20, ErrorMessage = "20 Characters or less")]
        public string FirstName { get; set; }
        [MaxLength(20,ErrorMessage="20 Characters or less")]
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "20 Characters or less")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "30 Characters or less")]
        public string Address { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "20 Characters or less")]
        public string City { get; set; }
        [Required]
        [MaxLength(2, ErrorMessage = "2 Characters or less")]
        public string State { get; set; }
        [Required]
        [MaxLength(5, ErrorMessage = "5 Characters or less")]
        public string ZCode { get; set; }
        [MaxLength(20, ErrorMessage = "20 Characters or less")]
        public string Email { get; set; }
        [CustomerTypeAttribute]
        [Required]
        public string CustomerType { get; set; }
        [Required]
        public int PurchaserID { get; set; }
        public int TicketsID { get; set; }
    }
    public sealed class CustomerTypeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var val = value.ToString();
            if (val != "Child" && val != "Purchaser" && val!="Member")
            {
                ErrorMessage = string.Format("Not a valid type");
                return false;
            }
            return true;
        }
    }

}
