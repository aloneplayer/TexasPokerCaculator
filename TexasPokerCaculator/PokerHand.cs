using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPokerCaculator
{
    public class PokerHand
    {
        public enum TexasPattern
        {
            HighHand,
            OnePair,
            TwoPairs,
            ThreeOfAKind, //3
            Straight,
            Flush,  //Five cards of the same suit.
            FullHouse,  //3+2
            FourOfAKind,  //4
            StraightFlush,  //tonghua-shun
            RoyalFlush, //A-tonghua-shun
        }

        private TexasPattern pattern;
        private List<Poker> pokers;

        public PokerHand(TexasPattern pattern, List<Poker> pokers)
        {
            this.pokers = pokers;
            this.pattern = pattern;
        }

        public List<Poker> Pokers
        {
            get
            {
                return pokers;
            }
        }

        public TexasPattern Pattern
        {
            get { return this.pattern; }
        }
    }
}
