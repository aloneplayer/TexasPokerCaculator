using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexasPokerCaculator
{
    public partial class Form1 : Form
    {
        private Rectangle rect_Player1;
        private Rectangle rect_Player2;
        private Rectangle rect_Player3;
        private Rectangle rect_Player4;
        private Rectangle rect_Player5;
        private Rectangle rect_Player6;
        private Rectangle rect_Player7;
        private Rectangle rect_Player8;
        private Rectangle rect_Player9;
        private Rectangle rect_Player10;

        private const int SmallPokerWidth = 17;
        private const int SmallPokerHeight = 36;
        private const int SmallPokerPicTopMargin = 4;
        private const int SmallPokerPicLeftMargin = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region UI functions
        private void DrawBoxForPlayers(Graphics g)
        {
            int tablePicWidth = this.pictureBox_Table.Width;
            int tablePicHeight = this.pictureBox_Table.Height;

            int centralAreaWidth = (int)(tablePicWidth * 16 / 27.7);
            int centralAreaHeight = (int)(tablePicHeight * 7.5 / 16);

            int leftMargin = (tablePicWidth - centralAreaWidth) / 2;
            int topMargin = (tablePicHeight - centralAreaHeight) / 2;

            // Draw next line and...
            g.DrawRectangle(Pens.Red, leftMargin, topMargin, centralAreaWidth, centralAreaHeight);

            int boxWidth = (int)(centralAreaWidth * 0.8 / 4);
            int boxHeight = (int)(centralAreaHeight * 0.8 / 2);

            int boxHorizontalGap = (int)(centralAreaWidth * 0.2 / 3);

            //Draw top row boxes
            rect_Player2 = new Rectangle(leftMargin, topMargin, boxWidth, boxHeight);
            g.DrawRectangle(Pens.Red, rect_Player2);
            
            rect_Player3 = new Rectangle(leftMargin + boxWidth + boxHorizontalGap, topMargin, boxWidth, boxHeight);
            g.DrawRectangle(Pens.Red, rect_Player3);
            
            rect_Player4 = new Rectangle(leftMargin + 2 * boxWidth + 2 * boxHorizontalGap, topMargin, boxWidth, boxHeight);
            g.DrawRectangle(Pens.Red, rect_Player4);
            
            rect_Player5 = new Rectangle(leftMargin + 3 * boxWidth + 3 * boxHorizontalGap, topMargin, boxWidth, boxHeight);
            g.DrawRectangle(Pens.Red, rect_Player5);

            //Draw bottom row boxes
            int boxY = topMargin + centralAreaHeight - boxHeight;
            rect_Player10 = new Rectangle(leftMargin, boxY, boxWidth, boxHeight);
            g.DrawRectangle(Pens.Red, rect_Player10);

            rect_Player9 = new Rectangle(leftMargin + boxWidth + boxHorizontalGap, boxY, boxWidth, boxHeight);
            g.DrawRectangle(Pens.Red, rect_Player9);

            rect_Player8 = new Rectangle(leftMargin + 2 * boxWidth + 2 * boxHorizontalGap, boxY, boxWidth, boxHeight);
            g.DrawRectangle(Pens.Red, rect_Player8);

            rect_Player7 = new Rectangle(leftMargin + 3 * boxWidth + 3 * boxHorizontalGap, boxY, boxWidth, boxHeight);
            g.DrawRectangle(Pens.Red, rect_Player7);


            //Draw left column box 
            int boxX = leftMargin - boxWidth;
            boxY = topMargin + (int)((centralAreaHeight - boxHeight) / 2);
            rect_Player1 = new Rectangle(boxX, boxY, boxWidth, boxHeight);
            g.DrawRectangle(Pens.Red, rect_Player1);

            //Draw right column box 
            boxX = leftMargin + centralAreaWidth;
            rect_Player6 = new Rectangle(boxX, boxY, boxWidth, boxHeight);
            g.DrawRectangle(Pens.Red, rect_Player6);
        }

        private void DrawPokerStackHighlightBox()
        { 
        
        }
        #endregion


        private void pictureBox_Table_Paint(object sender, PaintEventArgs e)
        {
            DrawBoxForPlayers(e.Graphics);
        }

        private void pictureBox_PokerStack_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
