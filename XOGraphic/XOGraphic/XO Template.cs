using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace XOGraphic
{
    public partial class XO_Template : UserControl
    {
        private const int RowCount = 3;
        private const int ColumnCount = 3;
        private const int PlayersCount = 2;


        Game game;

        public Game Game { set { game = value; } }


        public XO_Template()
        {
            InitializeComponent();
            game = new Game();
            this.Click += new EventHandler(XO_Template_Click);
            
        }

        private void XO_Template_Click(object sender, EventArgs e)
        {
            MouseEventArgs ee = (MouseEventArgs)e;
            
            game.Next(GetiPos(ee.X, ee.Y));
            this.Invalidate();
        }

        private int GetiPos(int x, int y)
        {
            int i = x / (Width / RowCount);
            int j = y / (Height / ColumnCount);
            return (j * RowCount) + i;

        }
        protected override void OnPaint(PaintEventArgs e)
        {
    
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                game.DrawGame(e.Graphics, Width, Height);
            if (game.RoundFlag == true)
            {
                MessageBox.Show(game.ToString());
                game.RoundFlag = false;
            }
            

        }


        protected override void OnResize(EventArgs e)
        {

            this.Invalidate();
            
        }

        private void XO_Template_Load(object sender, EventArgs e)
        {

        }
    }
}
