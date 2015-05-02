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

        /// <summary>
        /// System Data  
        /// </summary>
        private PokerGroup commonPokers = new PokerGroup(5);
        private PokerGroup holeCards = new PokerGroup(2);
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
            this.SetupPokerRects();
            this.DrawPokerTable();
        }

        #region UI functions
        /// <summary>
        /// Draw common poker pools and dealer poker pool
        /// </summary>
        /// <param name="g"></param>
        private void SetupPokerRects()
        {
            int tablePicWidth = this.pictureBox_Table.Width;
            int tablePicHeight = this.pictureBox_Table.Height;

            int centralAreaWidth = (int)(tablePicWidth * 16 / 27.7);
            int centralAreaHeight = (int)(tablePicHeight * 7.5 / 16);

            int leftMargin = (tablePicWidth - centralAreaWidth) / 2;
            int topMargin = (tablePicHeight - centralAreaHeight) / 2;

            //int pokerGap = 10;

            int commonPokersRectWidth = CardWidth * 5 + CardGap * (4 + 2);
            int commonPokersRectHeight = CardHeight;
            int commonPokersRectLeft = leftMargin + (centralAreaWidth - commonPokersRectWidth) / 2;
            int commonPokersRectTop = (int)(topMargin + (centralAreaHeight - commonPokersRectHeight) / 2 - centralAreaHeight * 0.2);
            commonPokers.OutlineRect = new Rectangle(commonPokersRectLeft, commonPokersRectTop, commonPokersRectWidth, commonPokersRectHeight);
            commonPokers.PokerRects.Clear();
            for (int i = 0; i < commonPokers.Count; i++)
            {
                int x = commonPokers.OutlineRect.X + (CardWidth + CardGap) * i;
                int y = commonPokers.OutlineRect.Y;
                if (i > 2)
                {
                    x += 2 * CardGap;
                }

                commonPokers.PokerRects.Add(new Rectangle(x, y, CardWidth, CardHeight));
            }

            int holeCardsRectWidth = CardWidth * 2 + CardGap;
            int holeCardsRectHeight = CardHeight;
            int holeCardsRectLeft = leftMargin + (centralAreaWidth - holeCardsRectWidth) / 2;
            int holeCardsRectTop = topMargin + centralAreaHeight - commonPokersRectHeight;
            holeCards.OutlineRect = new Rectangle(holeCardsRectLeft, holeCardsRectTop, holeCardsRectWidth, holeCardsRectHeight);
            holeCards.PokerRects.Clear();
            for (int i = 0; i < holeCards.Count; i++)
            {
                int x = holeCards.OutlineRect.X + (CardWidth + CardGap) * i;
                int y = holeCards.OutlineRect.Y;
                holeCards.PokerRects.Add(new Rectangle(x, y, CardWidth, CardHeight));
            }
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

        private void DrawPokerCard(Graphics g, Poker.PokerSuits pokerSuit, int pokerPoint, Rectangle rect)
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
            g.DrawImage(CroppedImage, rect.X, rect.Y);
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
            if (this.pictureBox_Table.ClientSize.Height > 0 && this.pictureBox_Table.ClientSize.Width > 0)
            {
                Bitmap image = new Bitmap(this.pictureBox_Table.ClientSize.Width,
                                         this.pictureBox_Table.ClientSize.Height);
                Graphics g = Graphics.FromImage(image);
#if UIDEBUG
                g.DrawRectangle(Pens.Red, commonPokers.OutlineRect);

                for (int i = 0; i < commonPokers.PokerRects.Count; i++)
                {
                    g.DrawRectangle(Pens.Red, commonPokers.PokerRects[i]);
                }


                g.DrawRectangle(Pens.Red, holeCards.OutlineRect);
                for (int i = 0; i < holeCards.PokerRects.Count; i++)
                {
                    g.DrawRectangle(Pens.Red, holeCards.PokerRects[i]);
                }
#endif
               
                for (int i = 0; i < commonPokers.Count; i++)
                {
                    PokerSlot ps = commonPokers[i];
                    if (!ps.IsEmpty)
                    {
                        DrawPokerCard(g, ps.Poker.Suit, ps.Poker.Point, commonPokers.PokerRects[i]);
                    }
                }
                for (int i = 0; i < holeCards.Count; i++)
                {
                    PokerSlot ps = holeCards[i];
                    if (!ps.IsEmpty)
                    {
                        DrawPokerCard(g, ps.Poker.Suit, ps.Poker.Point, holeCards.PokerRects[i]);
                    }
                }
                this.pictureBox_Table.Image = image;
            }
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
                        if (holeCards.IsFull)
                        {
                            MessageBox.Show("deal pool is full");
                            return;
                        }
                    }
                    else
                    {
                        if (commonPokers.IsFull)
                        {
                            MessageBox.Show("Poker pool is full");
                            return;
                        }
                    }

                    if (pokerForDealer)
                    {
                        this.holeCards.InsterPoker((Poker.PokerSuits)yPokerIndex, xPokerIndex);
                    }
                    else
                    {
                        this.commonPokers.InsterPoker((Poker.PokerSuits)yPokerIndex, xPokerIndex);
                    }
                    DrawPokerTable();
                    this.pokerStack.DealPoker(pokerValue);
                    this.DrawPokersInPokerStack();

                }
                else  // Pocker is out of stack, click on it will put pocker back
                {

                    this.holeCards.RemovePoker((Poker.PokerSuits)yPokerIndex, xPokerIndex);

                    this.commonPokers.RemovePoker((Poker.PokerSuits)yPokerIndex, xPokerIndex);

                    DrawPokerTable();
                    this.pokerStack.RecallPoker(pokerValue);
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
            TexasPokerAI pokerAI = new TexasPokerAI(commonPokers, holeCards);

            PokerHand pokerHand = pokerAI.CalculatePattern();

            this.label_CurrentBest.Text = NameMapping.PatternNameMapping[pokerHand.Pattern];
        }

        private void pictureBox_Table_SizeChanged(object sender, EventArgs e)
        {
            this.SetupPokerRects();
            this.pictureBox_Table.Invalidate();
            this.DrawPokerTable();
        }

       
        #region Event Hander for the poker Table

        #endregion
    }
}
