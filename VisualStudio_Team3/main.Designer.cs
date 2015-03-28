namespace VisualStudio_Team3
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_buyTickets = new System.Windows.Forms.Button();
            this.lbl_Row = new System.Windows.Forms.Label();
            this.cb_row = new System.Windows.Forms.ComboBox();
            this.lbl_Seats = new System.Windows.Forms.Label();
            this.cb_ticket = new System.Windows.Forms.ComboBox();
            this.lbl_game = new System.Windows.Forms.Label();
            this.cb_game = new System.Windows.Forms.ComboBox();
            this.cb_section = new System.Windows.Forms.ComboBox();
            this.lbl_section = new System.Windows.Forms.Label();
            this.lbl_Cust = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_address2 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_namefill = new System.Windows.Forms.Label();
            this.lbl_addressfill = new System.Windows.Forms.Label();
            this.lbl_address2fill = new System.Windows.Forms.Label();
            this.lbl_emailfill = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 766);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // btn_buyTickets
            // 
            this.btn_buyTickets.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_buyTickets.Location = new System.Drawing.Point(741, 715);
            this.btn_buyTickets.Name = "btn_buyTickets";
            this.btn_buyTickets.Size = new System.Drawing.Size(121, 35);
            this.btn_buyTickets.TabIndex = 4;
            this.btn_buyTickets.Text = "Buy Tickets";
            this.btn_buyTickets.UseVisualStyleBackColor = true;
            this.btn_buyTickets.Click += new System.EventHandler(this.btn_buyTickets_Click);
            // 
            // lbl_Row
            // 
            this.lbl_Row.AutoSize = true;
            this.lbl_Row.Location = new System.Drawing.Point(737, 469);
            this.lbl_Row.Name = "lbl_Row";
            this.lbl_Row.Size = new System.Drawing.Size(219, 20);
            this.lbl_Row.TabIndex = 6;
            this.lbl_Row.Text = "Please Select a Row Number:";
            // 
            // cb_row
            // 
            this.cb_row.FormattingEnabled = true;
            this.cb_row.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_row.Location = new System.Drawing.Point(741, 506);
            this.cb_row.Name = "cb_row";
            this.cb_row.Size = new System.Drawing.Size(121, 28);
            this.cb_row.TabIndex = 5;
            // 
            // lbl_Seats
            // 
            this.lbl_Seats.AutoSize = true;
            this.lbl_Seats.Location = new System.Drawing.Point(737, 573);
            this.lbl_Seats.Name = "lbl_Seats";
            this.lbl_Seats.Size = new System.Drawing.Size(255, 20);
            this.lbl_Seats.TabIndex = 8;
            this.lbl_Seats.Text = "Please Select a Number of Tickets:";
            // 
            // cb_ticket
            // 
            this.cb_ticket.FormattingEnabled = true;
            this.cb_ticket.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cb_ticket.Location = new System.Drawing.Point(741, 610);
            this.cb_ticket.Name = "cb_ticket";
            this.cb_ticket.Size = new System.Drawing.Size(121, 28);
            this.cb_ticket.TabIndex = 7;
            // 
            // lbl_game
            // 
            this.lbl_game.AutoSize = true;
            this.lbl_game.Location = new System.Drawing.Point(737, 271);
            this.lbl_game.Name = "lbl_game";
            this.lbl_game.Size = new System.Drawing.Size(171, 20);
            this.lbl_game.TabIndex = 11;
            this.lbl_game.Text = "Please Select a Game:";
            // 
            // cb_game
            // 
            this.cb_game.FormattingEnabled = true;
            this.cb_game.Items.AddRange(new object[] {
            "Game 1",
            "Game 2",
            "Game 3",
            "Game 4",
            "Game 5",
            "Game 6",
            "Game 7",
            "Game 8",
            "Game 9",
            "Game 10",
            "Game 11",
            "Game 12",
            "Finals 1",
            "Finals 2"});
            this.cb_game.Location = new System.Drawing.Point(741, 308);
            this.cb_game.Name = "cb_game";
            this.cb_game.Size = new System.Drawing.Size(121, 28);
            this.cb_game.TabIndex = 10;
            // 
            // cb_section
            // 
            this.cb_section.FormattingEnabled = true;
            this.cb_section.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "301",
            "302",
            "303",
            "321",
            "322",
            "323"});
            this.cb_section.Location = new System.Drawing.Point(741, 407);
            this.cb_section.Name = "cb_section";
            this.cb_section.Size = new System.Drawing.Size(121, 28);
            this.cb_section.TabIndex = 1;
            // 
            // lbl_section
            // 
            this.lbl_section.AutoSize = true;
            this.lbl_section.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbl_section.Location = new System.Drawing.Point(737, 370);
            this.lbl_section.Name = "lbl_section";
            this.lbl_section.Size = new System.Drawing.Size(222, 20);
            this.lbl_section.TabIndex = 2;
            this.lbl_section.Text = "Please Select a Section Level:";
            // 
            // lbl_Cust
            // 
            this.lbl_Cust.AutoSize = true;
            this.lbl_Cust.Location = new System.Drawing.Point(737, 23);
            this.lbl_Cust.Name = "lbl_Cust";
            this.lbl_Cust.Size = new System.Drawing.Size(167, 20);
            this.lbl_Cust.TabIndex = 12;
            this.lbl_Cust.Text = "Customer Information:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(737, 61);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 20);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(737, 101);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(72, 20);
            this.lbl_address.TabIndex = 14;
            this.lbl_address.Text = "Address:";
            // 
            // lbl_address2
            // 
            this.lbl_address2.AutoSize = true;
            this.lbl_address2.Location = new System.Drawing.Point(737, 144);
            this.lbl_address2.Name = "lbl_address2";
            this.lbl_address2.Size = new System.Drawing.Size(85, 20);
            this.lbl_address2.TabIndex = 15;
            this.lbl_address2.Text = "Address 2:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(737, 185);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(52, 20);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_namefill
            // 
            this.lbl_namefill.AutoSize = true;
            this.lbl_namefill.Location = new System.Drawing.Point(798, 61);
            this.lbl_namefill.Name = "lbl_namefill";
            this.lbl_namefill.Size = new System.Drawing.Size(0, 20);
            this.lbl_namefill.TabIndex = 17;
            // 
            // lbl_addressfill
            // 
            this.lbl_addressfill.AutoSize = true;
            this.lbl_addressfill.Location = new System.Drawing.Point(811, 101);
            this.lbl_addressfill.Name = "lbl_addressfill";
            this.lbl_addressfill.Size = new System.Drawing.Size(0, 20);
            this.lbl_addressfill.TabIndex = 18;
            // 
            // lbl_address2fill
            // 
            this.lbl_address2fill.AutoSize = true;
            this.lbl_address2fill.Location = new System.Drawing.Point(828, 144);
            this.lbl_address2fill.Name = "lbl_address2fill";
            this.lbl_address2fill.Size = new System.Drawing.Size(0, 20);
            this.lbl_address2fill.TabIndex = 19;
            // 
            // lbl_emailfill
            // 
            this.lbl_emailfill.AutoSize = true;
            this.lbl_emailfill.Location = new System.Drawing.Point(795, 185);
            this.lbl_emailfill.Name = "lbl_emailfill";
            this.lbl_emailfill.Size = new System.Drawing.Size(0, 20);
            this.lbl_emailfill.TabIndex = 20;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 780);
            this.Controls.Add(this.lbl_emailfill);
            this.Controls.Add(this.lbl_address2fill);
            this.Controls.Add(this.lbl_addressfill);
            this.Controls.Add(this.lbl_namefill);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_address2);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_Cust);
            this.Controls.Add(this.lbl_game);
            this.Controls.Add(this.cb_game);
            this.Controls.Add(this.lbl_Seats);
            this.Controls.Add(this.cb_ticket);
            this.Controls.Add(this.lbl_Row);
            this.Controls.Add(this.cb_row);
            this.Controls.Add(this.btn_buyTickets);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_section);
            this.Controls.Add(this.cb_section);
            this.Controls.Add(this.pictureBox1);
            this.Name = "main";
            this.Text = "Buy Some Fake TICKETS!!!!";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_buyTickets;
        private System.Windows.Forms.Label lbl_Row;
        private System.Windows.Forms.ComboBox cb_row;
        private System.Windows.Forms.Label lbl_Seats;
        private System.Windows.Forms.ComboBox cb_ticket;
        private System.Windows.Forms.Label lbl_game;
        private System.Windows.Forms.ComboBox cb_game;
        private System.Windows.Forms.ComboBox cb_section;
        private System.Windows.Forms.Label lbl_section;
        private System.Windows.Forms.Label lbl_Cust;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_address2;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_namefill;
        private System.Windows.Forms.Label lbl_addressfill;
        private System.Windows.Forms.Label lbl_address2fill;
        private System.Windows.Forms.Label lbl_emailfill;
    }
}

