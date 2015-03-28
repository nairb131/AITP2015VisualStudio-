using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualStudio_Team3
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btn_buyTickets_Click(object sender, EventArgs e)
        {
            decimal ticketprice;

            string section = cb_section.SelectedItem.ToString();

            string game = cb_game.SelectedItem.ToString();

            //if (section < 107 || section >= 118 && section <= 124)
            //{
            //    ticketprice = 38;
            //}
            //if (section < 200)
            //{
            //    ticketprice = 37;
            //}
            //else
            //{
            //    ticketprice = 36;
            //}
            //if (game == "Game 5" || game == "Game 7" || game == "Game 11")
            //{
            //    ticketprice -= 5;
            //}
            //if (game == "Game 6" || game == "Game 8" || game == "Game 9" || game == "Game 10" || game == "Game 12" )
            //{
            //    ticketprice -= 3;
            //}
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
