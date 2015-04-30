using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPokerCaculator
{
    public class PokerSlot
    {
        public enum PokerState
        {
            Back,
            Face,
        }

        private Poker poker;

        public bool IsEmpty
        {
            get { return this.poker == null; }
        }

        public Poker Poker
        {
            get { return poker; }
        }

        public void InsertPoker(Poker.PokerSuits suit, int point)
        {
            this.poker = new Poker(suit, point);
        }

        public void Clear()
        {
            this.poker = null;
        }
    }


}
