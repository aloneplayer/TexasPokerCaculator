using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPokerCaculator
{
    public class NameMapping
    {
        public static Dictionary<PokerHand.TexasPattern, string> PatternNameMapping;
        public static Dictionary<Poker.PokerSuits, string> PokerSuitNameMapping;
        public static Dictionary<int, string> PokerPointNameMapping;

        static NameMapping()
        {
            PatternNameMapping = new Dictionary<PokerHand.TexasPattern, string>();
            PatternNameMapping.Add(PokerHand.TexasPattern.HighHand, "高牌");
            PatternNameMapping.Add(PokerHand.TexasPattern.OnePair, "一对");
            PatternNameMapping.Add(PokerHand.TexasPattern.TwoPairs, "两对");
            PatternNameMapping.Add(PokerHand.TexasPattern.ThreeOfAKind, "三条");
            PatternNameMapping.Add(PokerHand.TexasPattern.Straight, "顺子");
            PatternNameMapping.Add(PokerHand.TexasPattern.Flush, "同花"); //Five cards of the same suit.
            PatternNameMapping.Add(PokerHand.TexasPattern.FullHouse, "满堂红");  //3+2
            PatternNameMapping.Add(PokerHand.TexasPattern.FourOfAKind, "四条");
            PatternNameMapping.Add(PokerHand.TexasPattern.StraightFlush, "同花顺");
            PatternNameMapping.Add(PokerHand.TexasPattern.RoyalFlush, "同花大顺");

            PokerSuitNameMapping = new Dictionary<Poker.PokerSuits, string>();
            PokerSuitNameMapping.Add(Poker.PokerSuits.Hearts, "红桃");
            PokerSuitNameMapping.Add(Poker.PokerSuits.Spades, "黑桃");
            PokerSuitNameMapping.Add(Poker.PokerSuits.Diamonds, "方块");
            PokerSuitNameMapping.Add(Poker.PokerSuits.Clubs, "梅花");

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
    }
}
