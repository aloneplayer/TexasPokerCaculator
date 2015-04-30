#define UIDEBUG

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
        private const int CardGap = 10;

        private Rectangle CommonPokerPoolRect;
        private Rectangle DealerPokerPoolRect;

        /// <summary>
        /// System Data  
        /// </summary>
        private PokerPool commonPokerPool = new PokerPool(5);
        private PokerPool dealerPokerPool = new PokerPool(2);
        private PokerStack pokerStack = new PokerStack();

        public Form1()
        {
            InitializeComponent();
        }
        static Form1()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetupPokerPoolBoxes();
        }

        #region UI functions
        /// <summary>
        /// Draw common poker pools and dealer poker pool
        /// </summary>
        /// <param name="g"></param>
        private void SetupPokerPoolBoxes()
        {
            int tablePicWidth = this.pictureBox_Table.Width;
            int tablePicHeight = this.pictureBox_Table.Height;

            int centralAreaWidth = (int)(tablePicWidth * 16 / 27.7);
            int centralAreaHeight = (int)(tablePicHeight * 7.5 / 16);

            int leftMargin = (tablePicWidth - centralAreaWidth) / 2;
            int topMargin = (tablePicHeight - centralAreaHeight) / 2;

            //int pokerGap = 10;

            int pokerPoolWidth = CardWidth * 5 + CardGap * 4;
            int pokerPoolHeight = CardHeight;
            int pokerPoolLeft = leftMargin + (centralAreaWidth - pokerPoolWidth) / 2;
            int pokerPoolTop = (int)(topMargin + (centralAreaHeight - pokerPoolHeight) / 2 - centralAreaHeight * 0.2);
            CommonPokerPoolRect = new Rectangle(pokerPoolLeft, pokerPoolTop, pokerPoolWidth, pokerPoolHeight);

            int dealerPokerPoolWidth = CardWidth * 2 + CardGap;
            int dealerPokerPoolHeight = CardHeight;
            int dealerPokeroolLeft = leftMargin + (centralAreaWidth - dealerPokerPoolWidth) / 2;
            int dealerPokerPoolTop = topMargin + centralAreaHeight - pokerPoolHeight;
            DealerPokerPoolRect = new Rectangle(dealerPokeroolLeft, dealerPokerPoolTop, dealerPokerPoolWidth, dealerPokerPoolHeight);

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
#if UIDEBUG
            Graphics g = e.Graphics;

            g.DrawRectangle(Pens.Red, CommonPokerPoolRect);

            int pokerPoolLeft = CommonPokerPoolRect.Left;
            int pokerPoolTop = CommonPokerPoolRect.Top;
            g.DrawRectangle(Pens.Red, pokerPoolLeft, pokerPoolTop, CardWidth, CardHeight);
            g.DrawRectangle(Pens.Red, pokerPoolLeft + CardWidth + CardGap, pokerPoolTop, CardWidth, CardHeight);
            g.DrawRectangle(Pens.Red, pokerPoolLeft + 2 * CardGap + 2 * CardWidth, pokerPoolTop, CardWidth, CardHeight);
            g.DrawRectangle(Pens.Red, pokerPoolLeft + 3 * CardGap + 3 * CardWidth, pokerPoolTop, CardWidth, CardHeight);
            g.DrawRectangle(Pens.Red, pokerPoolLeft + 4 * CardGap + 4 * CardWidth, pokerPoolTop, CardWidth, CardHeight);


            g.DrawRectangle(Pens.Red, DealerPokerPoolRect);
            pokerPoolLeft = DealerPokerPoolRect.Left;
            pokerPoolTop = DealerPokerPoolRect.Top;
            g.DrawRectangle(Pens.Red, pokerPoolLeft, pokerPoolTop, CardWidth, CardHeight);
            g.DrawRectangle(Pens.Red, pokerPoolLeft + CardWidth + CardGap, pokerPoolTop, CardWidth, CardHeight);
#endif
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.SetupPokerPoolBoxes();
            this.DrawPokerTable();
        }

        private void DrawPokerCard(Graphics g, Poker.PokerSuits pokerSuit, int pokerPoint, int x, int y)
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

            int colIndex = pokerPoint;
            int rowIndex = (int)pokerSuit;

            int xCard = marginLeft + colIndex * CardWidth + colIndex * gapX;
            int yCard = marginTop + rowIndex * CardHeight + rowIndex * gapY;

            Bitmap source = new Bitmap(TexasPokerCaculator.Properties.Resources.PokerCards);
            //The section should be 1pix bigger than the pic I want to cut
            Rectangle section = new Rectangle(xCard, yCard, CardWidth + 1, CardHeight + 1);
            Bitmap CroppedImage = source.Clone(section, source.PixelFormat);
            g.DrawImage(CroppedImage, x, y);
            source.Dispose();
        }

        private void DrawPokersInPokerStack()
        {
            Bitmap image = new Bitmap(this.pictureBox_PokerStack.ClientSize.Width,
                                      this.pictureBox_PokerStack.ClientSize.Height);
            Graphics g = Graphics.FromImage(image);
            for (int yIndex = 0; yIndex < 4; yIndex++)
            {
                for (int xIndex = 0; xIndex < 13; xIndex++)
                {

                    int pokerValue = Poker.GetValue(yIndex, xIndex);
                    int xBox = SmallPokerPicLeftMargin + xIndex * SmallPokerWidth;
                    int yBox = SmallPokerPicTopMargin + yIndex * SmallPokerHeight;

                    if ((pokerStack[pokerValue] & PokerStack.PokerState.HighLight) == PokerStack.PokerState.HighLight)
                    {
                        //Draw highligh
                        g.DrawRectangle(new Pen(Color.Blue, 2), xBox, yBox, SmallPokerWidth + 1, SmallPokerHeight + 1);
                    }
                    if ((pokerStack[pokerValue] & PokerStack.PokerState.OutStack) == PokerStack.PokerState.OutStack)
                    {
                        //Draw mask
                        g.DrawLine(new Pen(Color.Blue, 2), xBox, yBox, xBox + SmallPokerWidth + 1, yBox + SmallPokerHeight);
                        g.DrawLine(new Pen(Color.Blue, 2), xBox, yBox + SmallPokerHeight, xBox + SmallPokerWidth + 1, yBox);
                    }
                }
            }
            this.pictureBox_PokerStack.Image = image;
        }

        private void DrawPokerTable()
        {
            Bitmap image = new Bitmap(this.pictureBox_Table.ClientSize.Width,
                                      this.pictureBox_Table.ClientSize.Height);
            Graphics g = Graphics.FromImage(image);
            for (int i = 0; i < commonPokerPool.Count; i++)
            {
                PokerSlot ps = commonPokerPool[i];
                if (!ps.IsEmpty)
                {
                    int x = CommonPokerPoolRect.X + (CardWidth + CardGap) * i;
                    int y = CommonPokerPoolRect.Y;
                    DrawPokerCard(g, ps.Poker.Suit, ps.Poker.Point, x, y);
                }
            }
            for (int i = 0; i < dealerPokerPool.Count; i++)
            {
                PokerSlot ps = dealerPokerPool[i];
                if (!ps.IsEmpty)
                {
                    int x = DealerPokerPoolRect.X + (CardWidth + CardGap) * i;
                    int y = DealerPokerPoolRect.Y;
                    DrawPokerCard(g, ps.Poker.Suit, ps.Poker.Point, x, y);
                }
            }
            this.pictureBox_Table.Image = image;
        }

        #region  Event handler for poker stack

        private void pictureBox_PokerStack_MouseMove(object sender, MouseEventArgs e)
        {
            int xPokerIndex = 0;
            int yPokerIndex = 0;
            PokerUnderMouser(e.X, e.Y, out xPokerIndex, out yPokerIndex);

            if (xPokerIndex < 13 && yPokerIndex < 4)
            {
                //For debug
                //String tipText = String.Format("({0}, {1})", xPokerIndex, yPokerIndex);
                //this.toolTip1.Show(tipText, this, e.Location);
                this.pokerStack.HighLightPoker(yPokerIndex, xPokerIndex);
                this.DrawPokersInPokerStack();
            }
        }

        private void PokerUnderMouser(int mouseX, int mouseY, out int xIndex, out int yIndex)
        {
            xIndex = (mouseX - SmallPokerPicLeftMargin) / SmallPokerWidth;
            yIndex = (mouseY - SmallPokerPicTopMargin) / SmallPokerHeight;
        }
        private void pictureBox_PokerStack_MouseClick(object sender, MouseEventArgs e)
        {
            bool pokerForDealer = (e.Button == System.Windows.Forms.MouseButtons.Right);

            int xPokerIndex = 0;
            int yPokerIndex = 0;
            PokerUnderMouser(e.X, e.Y, out xPokerIndex, out yPokerIndex);

            if (xPokerIndex < 13 && yPokerIndex < 4)
            {
                int pokerValue = Poker.GetValue(yPokerIndex, xPokerIndex);
                if ((this.pokerStack[pokerValue] & PokerStack.PokerState.InStack) == PokerStack.PokerState.InStack)
                {
                    if (pokerForDealer)
                    {
                        if (dealerPokerPool.IsFull)
                        {
                            MessageBox.Show("deal pool is full");
                            return;
                        }
                    }
                    else
                    {
                        if (commonPokerPool.IsFull)
                        {
                            MessageBox.Show("Poker pool is full");
                            return;
                        }
                    }

                    if (pokerForDealer)
                    {
                        this.dealerPokerPool.InsterPoker((Poker.PokerSuits)yPokerIndex, xPokerIndex);
                    }
                    else
                    {
                        this.commonPokerPool.InsterPoker((Poker.PokerSuits)yPokerIndex, xPokerIndex);
                    }
                    DrawPokerTable();
                    this.pokerStack.TakePoker(pokerValue);
                    this.DrawPokersInPokerStack();

                }
                else  // Pocker is out of stack, click on it will put pocker back
                {

                    this.dealerPokerPool.RemovePoker((Poker.PokerSuits)yPokerIndex, xPokerIndex);

                    this.commonPokerPool.RemovePoker((Poker.PokerSuits)yPokerIndex, xPokerIndex);

                    DrawPokerTable();
                    this.pokerStack.PutBackPoker(pokerValue);
                    this.DrawPokersInPokerStack();
                }
            }
        }
        private void pictureBox_PokerStack_MouseLeave(object sender, EventArgs e)
        {
            this.pokerStack.UnHighLightAll();
            this.DrawPokersInPokerStack();
        }
        #endregion

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            TexasPokerAI pokerAI = new TexasPokerAI(commonPokerPool, dealerPokerPool);

            TexasPokerAI.Pattern pattern = pokerAI.CalculatePattern();

            this.label_CurrentBest.Text = TexasPokerAI.PatternNameMapping[pattern];
        }
        #region Event Hander for the poker Table
 
        #endregion
    }
}
