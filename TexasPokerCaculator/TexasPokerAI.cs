using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPokerCaculator
{
    public class TexasPokerAI
    {
        public static Dictionary<Pattern, string> PatternNameMapping;
        private List<Poker> pokers;
        public enum Pattern
        {
            Unknown,
            HighHand,
            OnePair,
            TwoPairs,
            ThreeOfAkind, //3
            Straight,
            Flush,  //Tong Hua
            FullHouse,  //3+2
            FourOfAKine,  //4
            StraightFlush,  //tonghua-shun
            RoyalFlush, //A-tonghua-shun
        }
        static TexasPokerAI()
        {
            PatternNameMapping = new Dictionary<Pattern, string>();
            PatternNameMapping.Add(Pattern.Unknown, "未知牌型");
            PatternNameMapping.Add(Pattern.HighHand, "高牌");
            PatternNameMapping.Add(Pattern.OnePair, "一对");
            PatternNameMapping.Add(Pattern.TwoPairs, "两对");
            PatternNameMapping.Add(Pattern.ThreeOfAkind, "三条");
            PatternNameMapping.Add(Pattern.Straight, "顺子");
            PatternNameMapping.Add(Pattern.Flush, "同花");
            PatternNameMapping.Add(Pattern.FullHouse, "满堂红");
            PatternNameMapping.Add(Pattern.FourOfAKine, "四条");
            PatternNameMapping.Add(Pattern.StraightFlush, "同花顺");
            PatternNameMapping.Add(Pattern.RoyalFlush, "同花大顺");
        }

        public TexasPokerAI()
        {
            pokers = new List<Poker>();
        }

        public TexasPokerAI(PokerPool commonPool, PokerPool playerPool)
        {
            pokers = new List<Poker>();

            for (int i = 0; i < commonPool.Count; i++)
            {
                if (!commonPool[i].IsEmpty)
                {
                    pokers.Add(new Poker(commonPool[i].Poker.Value));
                }
            }
            for (int i = 0; i < playerPool.Count; i++)
            {
                if (!playerPool[i].IsEmpty)
                {
                    pokers.Add(new Poker(playerPool[i].Poker.Value));
                }
            }
        }

        public Pattern CalculatePattern()
        {
            int count = this.pokers.Count;
            if (count == 1)
            {
                return Pattern.HighHand;
            }
            if (count == 2)
            {
                if (pokers[0].Point == pokers[1].Point)
                    return Pattern.OnePair;
                else
                    return Pattern.HighHand;
            }
            if (count == 3)
            {
                if (pokers[0].Point == pokers[1].Point && pokers[1].Point == pokers[2].Point)
                    return Pattern.ThreeOfAkind;
                else if (pokers[0].Point == pokers[1].Point || pokers[1].Point == pokers[2].Point)
                    return Pattern.OnePair;
                else
                    return Pattern.HighHand;
            }

            return Pattern.Unknown;
        }

        /// <summary>
        /// Sort poker by points Descending 
        /// </summary>
        private void SortPokersByPoints()
        {
            pokers = pokers.OrderByDescending(x => x.Point).ToList<Poker>();    
        }

        private void SortPokerBySuitThenPoint()
        {
            pokers = pokers.OrderByDescending(x => x.Suit).ThenByDescending(x => x.Point).ToList<Poker>();    
        }

        private void SortPokerByPointThenSuit()
        {
            pokers = pokers.OrderByDescending(x => x.Point).ThenByDescending(x => x.Suit).ToList<Poker>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.pokers.Count; i++)
            {
                sb.Append(pokers[i].ToString());
                if (i < this.pokers.Count - 1)
                    sb.Append("-");
            }

            return sb.ToString();
        }
    }
}
