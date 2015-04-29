using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPokerCaculator
{
    public class Poker
    {
        public static Dictionary<int, string> PokerTypes;
        public static Dictionary<int, string> PokerPoint;

        private int value;
        public Poker(int value)
        {
            this.value = value;
        }

        public Poker(int type, int point)
        { 
        
        }

        static Poker()
        {
            PokerTypes = new Dictionary<int,string>();
            PokerTypes.Add(0, "红桃");
            PokerTypes.Add(1, "黑桃");
            PokerTypes.Add(2, "方块");
            PokerTypes.Add(3, "梅花");

            PokerPoint = new Dictionary<int,string>();
            PokerPoint.Add(0,"2");
            PokerPoint.Add(1,"3");
            PokerPoint.Add(2,"4");
            PokerPoint.Add(3,"5");
            PokerPoint.Add(4,"6");
            PokerPoint.Add(5,"7");
            PokerPoint.Add(6,"8");
            PokerPoint.Add(7,"9");
            PokerPoint.Add(8,"10");
            PokerPoint.Add(9,"J");
            PokerPoint.Add(10,"Q");
            PokerPoint.Add(11,"K");
            PokerPoint.Add(12,"A");
        }
    }
}
