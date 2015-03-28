using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualStudio_Team3.Models;
using System.Data.SqlClient;

namespace VisualStudio_Team3
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            ValidateNotEmpty();
            Customer cust = new Customer{
                Address = txt_address.Text,
                LastName = txt_last.Text,
                MiddleName = txt_middle.Text,
                FirstName = txt_first.Text,
                City = txt_city.Text,
                State = txt_state.Text,
                ZCode = txt_zip.Text,
                Email = txt_email.Text,
                CustomerType = "Purchaser"                                
            };


        }

        private void ValidateNotEmpty()
        {
            if (txt_first.Text == "" ||
                txt_last.Text == "" ||
                txt_address.Text == "" ||
                txt_city.Text == "" ||
                txt_state.Text == ""||
                txt_zip.Text == "" ||
                txt_emailconfirm.Text=="")
            {
                MessageBox.Show("Please enter a value for all fields aside from Middle Name which is optional");                
            }
            else
            {
                return;
            }
        }
    }
}
