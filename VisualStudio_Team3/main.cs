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

            int section = int(cb_section.SelectedItem);

            string game = string(cb_game.SelectedItem);

            if (section < 107)
            {
                ticketprice = 38;
            }
            if (section >= 107 && section <= 117)
            {
                ticketprice = 37;
            }
            else
            {
                ticketprice = 36;
            }
            if (game == "Game 1" || game == "Game 2" || game == "Game 3" || game == "Game 4" || game == "Finals 1" || game == "Finals 2" )
            {

            }
            if (game == "Game 5" || game == "Game 7" || game == "Game 11")
            {

            }
            if (game == "Game 6" || game == "Game 8" || game == "Game 9" || game == "Game 10" || game == "Game 12" )
            {

            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
