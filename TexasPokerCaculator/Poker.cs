using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPokerCaculator
{
    /// <summary>
    /// 2 to A
    /// Club,Diamon, Heart, Spade
    /// </summary>
    public class Poker
    {
        public enum PokerSuits
        {
            Unknown = -1,
            Clubs = 0,
            Diamonds,
            Hearts,
            Spades
        }
        private int value;

        public Poker(int value)
        {
            this.value = value;
        }

        public Poker(PokerSuits suit, int point)
        {
            this.value = Poker.GetValue((int)suit, point);
        }
        public int Value
        {
            get
            {
                return this.value;
            }
        }
        public PokerSuits Suit
        {
            get
            {
                return (PokerSuits)(this.value / 13);
            }
        }

        public int Point
        {
            get
            {
                return this.value % 13;
            }
        }
        public override string ToString()
        {
            return NameMapping.PokerSuitNameMapping[this.Suit] + NameMapping.PokerPointNameMapping[this.Point];
        }

        public static int GetValue(int suit, int point)
        {
            return 13 * (int)suit + point;
        }
    }
}
