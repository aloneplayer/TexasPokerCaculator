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
        public static Dictionary<PokerSuits, string> PokerSuitNameMapping;
        public static Dictionary<int, string> PokerPointNameMapping;

        private int value;

        static Poker()
        {
            PokerSuitNameMapping = new Dictionary<PokerSuits, string>();
            PokerSuitNameMapping.Add(PokerSuits.Hearts, "红桃");
            PokerSuitNameMapping.Add(PokerSuits.Spades, "黑桃");
            PokerSuitNameMapping.Add(PokerSuits.Diamonds, "方块");
            PokerSuitNameMapping.Add(PokerSuits.Clubs, "梅花");

            PokerPointNameMapping = new Dictionary<int, string>();
            PokerPointNameMapping.Add(0, "2");
            PokerPointNameMapping.Add(1, "3");
            PokerPointNameMapping.Add(2, "4");
            PokerPointNameMapping.Add(3, "5");
            PokerPointNameMapping.Add(4, "6");
            PokerPointNameMapping.Add(5, "7");
            PokerPointNameMapping.Add(6, "8");
            PokerPointNameMapping.Add(7, "9");
            PokerPointNameMapping.Add(8, "10");
            PokerPointNameMapping.Add(9, "J");
            PokerPointNameMapping.Add(10, "Q");
            PokerPointNameMapping.Add(11, "K");
            PokerPointNameMapping.Add(12, "A");
        }
        public Poker(int value)
        {
            this.value = value;
        }

        public Poker(PokerSuits suit, int point)
        {
            this.value = Poker.GetValue((int)suit, point);
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
            return PokerSuitNameMapping[this.Suit] + PokerPointNameMapping[this.Point];
        }

        public static int GetValue(int suit, int point)
        {
            return 13 * (int)suit + point;
        }
    }
}
