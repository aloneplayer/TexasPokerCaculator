using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPokerCaculator
{
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

        public Poker(int type, int point)
        {

        }

        static Poker()
        {
           
        }
    }
}
