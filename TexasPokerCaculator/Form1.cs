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

        private const int SmallPokerWidth = 19;
        private const int SmallPokerHeight = 36;
        private const int SmallPokerPicTopMargin = 3;
        private const int SmallPokerPicLeftMargin = 2;

        private const int CardWidth = 71;
        private const int CardHeight = 95;
        private Rectangle CommonPokerPoolRect;
        private Rectangle DealerPokerPoolRect; 

        public Form1()
        {
            InitializeComponent();
        }
        static Form1()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        #region UI functions
        /// <summary>
        /// Draw common poker pools and dealer poker pool
        /// </summary>
        /// <param name="g"></param>
        private void DrawPokerPools(Graphics g)
        {
            int tablePicWidth = this.pictureBox_Table.Width;
            int tablePicHeight = this.pictureBox_Table.Height;

            int centralAreaWidth = (int)(tablePicWidth * 16 / 27.7);
            int centralAreaHeight = (int)(tablePicHeight * 7.5 / 16);

            int leftMargin = (tablePicWidth - centralAreaWidth) / 2;
            int topMargin = (tablePicHeight - centralAreaHeight) / 2;

            int pokerWidth = CardWidth;
            int pokerHeight = CardHeight;
            int pokerGap = 10;

            int pokerPoolWidth = pokerWidth * 5 + pokerGap * 4;
            int pokerPoolHeight = pokerHeight;
            int pokerPoolLeft = leftMargin + (centralAreaWidth - pokerPoolWidth) / 2;
            int pokerPoolTop = (int)(topMargin + (centralAreaHeight - pokerPoolHeight) / 2 - centralAreaHeight * 0.2);
            CommonPokerPoolRect = new Rectangle(pokerPoolLeft, pokerPoolTop, pokerPoolWidth, pokerPoolHeight);
            g.DrawRectangle(Pens.Red, pokerPoolLeft, pokerPoolTop, pokerPoolWidth, pokerPoolHeight);

            g.DrawRectangle(Pens.Red, pokerPoolLeft, pokerPoolTop, pokerWidth, pokerHeight);
            g.DrawRectangle(Pens.Red, pokerPoolLeft + pokerWidth + pokerGap, pokerPoolTop, pokerWidth, pokerHeight);
            g.DrawRectangle(Pens.Red, pokerPoolLeft + 2 * pokerGap + 2 * pokerWidth, pokerPoolTop, pokerWidth, pokerHeight);
            g.DrawRectangle(Pens.Red, pokerPoolLeft + 3 * pokerGap + 3 * pokerWidth, pokerPoolTop, pokerWidth, pokerHeight);
            g.DrawRectangle(Pens.Red, pokerPoolLeft + 4 * pokerGap + 4 * pokerWidth, pokerPoolTop, pokerWidth, pokerHeight);

            int dealerPokerPoolWidth = pokerWidth * 2 + pokerGap;
            int dealerPokerPoolHeight = pokerHeight;
            int dealerPokeroolLeft = leftMargin + (centralAreaWidth - dealerPokerPoolWidth) / 2;
            int dealerPokerPoolTop = topMargin + centralAreaHeight - pokerPoolHeight;
            DealerPokerPoolRect = new Rectangle(dealerPokeroolLeft, dealerPokerPoolTop, dealerPokerPoolWidth, dealerPokerPoolHeight);
            g.DrawRectangle(Pens.Red, dealerPokeroolLeft, dealerPokerPoolTop, dealerPokerPoolWidth, dealerPokerPoolHeight);

            g.DrawRectangle(Pens.Red, dealerPokeroolLeft, dealerPokerPoolTop, pokerWidth, pokerHeight);
            g.DrawRectangle(Pens.Red, dealerPokeroolLeft + pokerWidth + pokerGap, dealerPokerPoolTop, pokerWidth, pokerHeight);
        }
        /// <summary>
        /// Obsolete
        /// </summary>
        /// <param name="g"></param>
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

        #endregion


        private void pictureBox_Table_Paint(object sender, PaintEventArgs e)
        {
            DrawPokerPools(e.Graphics);
        }

        private void pictureBox_PokerStack_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            int xPokerIndex = (x - SmallPokerPicLeftMargin) / SmallPokerWidth;
            int yPokerIndex = (y - SmallPokerPicTopMargin) / SmallPokerHeight;

            if (xPokerIndex < 13 && yPokerIndex < 4)
            {
                ShowPokerName(xPokerIndex, yPokerIndex);

                //For debug
                //String tipText = String.Format("({0}, {1})", xPokerIndex, yPokerIndex);
                //this.toolTip1.Show(tipText, this, e.Location);

                // +xPokerIndex is the widths of the black line between poker
                int xBox = SmallPokerPicLeftMargin + xPokerIndex * SmallPokerWidth - 1;
                int yBox = SmallPokerPicTopMargin + yPokerIndex * SmallPokerHeight - 1;

                this.pictureBox_PokerStack.Refresh();
                Graphics g = this.pictureBox_PokerStack.CreateGraphics();
                g.DrawRectangle(new Pen(Color.Blue, 2), xBox, yBox, SmallPokerWidth + 1, SmallPokerHeight + 1);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void ShowPokerName(int xIndex, int yIndex)
        {
            string pokerType = Poker.PokerSuitNameMapping[(Poker.PokerSuits)yIndex];
            string pokerPoint = Poker.PokerPointNameMapping[xIndex];

            this.label_PokerName.Text = pokerType + pokerPoint;
        }

        private void DrawPokerCard(Graphics g, Poker.PokerSuits pokerSuit, int pokerPoint, Point location)
        {
            // Details the all-in-one image
            // marginLeft =1
            // margin top =1
            // gap between cars =1
            // card width =71
            // card Height = 95
            int marginLeft = 1;
            int marginTop = 1;
            int gapX = 2;
            int gapY = 3;
            int cardWidth = 71;
            int cardHeight = 95;
            
            int colIndex = pokerPoint;
            int rowIndex = (int)pokerSuit;

            int x = marginLeft + colIndex * cardWidth + colIndex * gapX;
            int y = marginTop + rowIndex * cardHeight + rowIndex * gapY;

            Bitmap source = new Bitmap(TexasPokerCaculator.Properties.Resources.PokerCards);
            Rectangle section = new Rectangle(x, y, cardWidth, cardHeight);
            Bitmap CroppedImage = source.Clone(section, source.PixelFormat);
            g.DrawImage(CroppedImage, location);
            source.Dispose();
        }

        private void pictureBox_PokerStack_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            int xPokerIndex = (x - SmallPokerPicLeftMargin) / SmallPokerWidth;
            int yPokerIndex = (y - SmallPokerPicTopMargin) / SmallPokerHeight;

            if (xPokerIndex < 13 && yPokerIndex < 4)
            {
                Graphics g = this.pictureBox_Table.CreateGraphics();
                DrawPokerCard(g, (Poker.PokerSuits)yPokerIndex, xPokerIndex, CommonPokerPoolRect.Location);
                DrawPokerCard(g, (Poker.PokerSuits)yPokerIndex, xPokerIndex, DealerPokerPoolRect.Location);
            }
        }
    }
}
