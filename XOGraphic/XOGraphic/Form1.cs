using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOGraphic
{
    public partial class Form1 : Form
    {
        Game g;
        public Form1()
        {

            InitializeComponent();
            g = new Game();
            xO_Template1.Game = g;
            

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            xO_Template1.Width = Convert.ToInt32(this.Width * 0.9);
            xO_Template1.Height = Convert.ToInt32(this.Height * 0.9);
            this.Width = this.Height;


        }

        private void xO_Template1_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (TxtO.Text == null || TxtX.Text == null)
            {
                MessageBox.Show("Fill the player names!");
                return;
            }
            g.players.First().playerName = TxtO.Text;
            g.players.Last().playerName = TxtX.Text;
            xO_Template1.Visible = true;
            TxtX.Visible = false;
            TxtO.Visible = false;
            submit.Visible = false;
            label1.Visible = false;
            label2.Visible = false;



        }
    }
}
