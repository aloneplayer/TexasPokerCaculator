using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPokerCaculator
{
    public class TexasPokerAI
    {
        private List<Poker> pokersInPool;

        public TexasPokerAI()
        {
            pokersInPool = new List<Poker>();
        }

        public TexasPokerAI(PokerPool commonPool, PokerPool playerPool)
        {
            pokersInPool = new List<Poker>();

            for (int i = 0; i < commonPool.Count; i++)
            {
                if (!commonPool[i].IsEmpty)
                {
                    pokersInPool.Add(new Poker(commonPool[i].Poker.Value));
                }
            }
            for (int i = 0; i < playerPool.Count; i++)
            {
                if (!playerPool[i].IsEmpty)
                {
                    pokersInPool.Add(new Poker(playerPool[i].Poker.Value));
                }
            }
        }
        
        public PokerHand CalculatePattern()
        {
            List<Poker> p = FindRoyalFlush(this.pokersInPool);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.RoyalFlush, p);
            }

            p = FindStraightFlush(this.pokersInPool);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.StraightFlush, p);
            }

            p = FindStraight(this.pokersInPool);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.Straight, p);
            }

            p = FindFlush(this.pokersInPool);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.Flush, p);
            }

            // 4
            p = FindFourOfAKind(this.pokersInPool);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.FourOfAKind, p);
            }

            //3+2
            p = FindFullHouse(this.pokersInPool);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.FullHouse, p);

            }
            // 2+2
            p = FindTwoPair(this.pokersInPool);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.TwoPairs, p);

            }

            //3
            p = FindThreeOfAKind(this.pokersInPool);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.ThreeOfAKind, p);
            }
            // 1 pair
            p = FindOnePair(this.pokersInPool);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.OnePair, p);
            }

            p = this.SortPokersByPoint(this.pokersInPool);
            return new PokerHand(PokerHand.TexasPattern.HighHand, p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Poker> FindRoyalFlush(List<Poker> pokers)
        {
            List<Poker> pStraightFlush = FindStraightFlush(pokers);
            if (pStraightFlush != null && pStraightFlush[0].Point == 12)
            {

                return pStraightFlush;
            }
            return null;
        }

        private List<Poker> FindStraightFlush(List<Poker> pokers)
        {
            List<Poker> pStraight = FindStraight(pokers);
            if (pStraight != null)
            {
                List<Poker> pStraightFlush = FindFlush(pStraight);
                if (pStraightFlush != null)
                {
                    return pStraightFlush;
                }
            }

            return null;
        }

        /// <summary>
        /// 5 pokers' point in sequence. 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private List<Poker> FindStraight(List<Poker> pokers)
        {
            List<Poker> p = SortPokersByPoint(pokers);
            for (int i = 0; i < pokers.Count - 4; i++)
            {
                if (p[i].Point == p[i + 1].Point + 1 &&
                    p[i].Point == p[i + 2].Point + 2 &&
                    p[i].Point == p[i + 3].Point + 3 &&
                    p[i].Point == p[i + 4].Point + 4)
                {
                    return ClonePokers(p, i, i + 4);
                }
            }
            return null;
        }

        /// <summary>
        /// 5 pokers have same suit
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private List<Poker> FindFlush(List<Poker> pokers)
        {
            List<Poker> p = SortPokersBySuit(pokers);
            for (int i = 0; i < p.Count - 4; i++)
            {
                if (p[i].Suit == p[i + 4].Suit)
                {
                    return ClonePokers(p, i, i + 4);
                }
            }
            return null;
        }
        private List<Poker> FindFourOfAKind(List<Poker> pokers)
        {
            List<Poker> p = SortPokersByPoint(pokers);

            for (int i = 0; i < p.Count - 3; i++)
            {
                if (p[i].Point == p[i + 3].Point)
                {
                    return ClonePokers(p, i, i + 3);
                }
            }
            return null;
        }
        private List<Poker> FindThreeOfAKind(List<Poker> pokers)
        {
            List<Poker> p = SortPokersByPoint(pokers);

            for (int i = 0; i < p.Count - 2; i++)
            {
                if (p[i].Point == p[i + 2].Point)
                    return ClonePokers(p, i, i + 2);
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pokers"></param>
        /// <returns></returns>
        private List<Poker> FindFullHouse(List<Poker> pokers)
        {
            List<Poker> p = this.SortPokersByPoint(pokers);
            List<Poker> p3Kind = FindThreeOfAKind(p);
            if (p3Kind != null)
            {
                List<Poker> pRest = RemovePokers(p, p3Kind);
                List<Poker> pPair = FindOnePair(pRest);
                if (pPair != null)
                {
                    pPair.AddRange(p3Kind);
                    return pPair;
                }
            }
            return null;
        }
        private List<Poker> FindTwoPair(List<Poker> pokers)
        {
            List<Poker> p = this.SortPokersByPoint(pokers);
            List<Poker> pPair = FindOnePair(p);
            if (pPair != null)
            {
                List<Poker> pRest = RemovePokers(p, pPair);
                List<Poker> pPair2 = FindOnePair(pRest);
                if (pPair2 != null)
                {
                    pPair.AddRange(pPair2);
                    return pPair;
                }
            }
            return null;
        }

        private List<Poker> FindOnePair(List<Poker> pokers)
        {
            List<Poker> p = this.SortPokersByPoint(pokers);

            for (int i = 0; i < p.Count - 1; i++)
            {
                if (p[i].Point == p[i + 1].Point)
                {
                    return ClonePokers(p, i, i + 1);
                }
            }
            return null;
        }

        /// <summary>
        /// Sort poker by points Descending 
        /// </summary>
        private List<Poker> SortPokersByPoint(List<Poker> pokers)
        {
            return pokers.OrderByDescending(x => x.Point).ToList<Poker>();
        }

        private List<Poker> SortPokersBySuit(List<Poker> pokers)
        {
            return pokers.OrderByDescending(x => x.Suit).ToList<Poker>();
        }

        private List<Poker> SortPokersBySuitThenPoint(List<Poker> pokers)
        {
            return pokers.OrderByDescending(x => x.Suit).ThenByDescending(x => x.Point).ToList<Poker>();
        }

        private List<Poker> SortPokersByPointThenSuit(List<Poker> pokers)
        {
            return pokers.OrderByDescending(x => x.Point).ThenByDescending(x => x.Suit).ToList<Poker>();
        }

        private List<Poker> ClonePokers(List<Poker> pokers, int start, int end)
        {
            List<Poker> p = new List<Poker>();
            for (int i = start; i <= end; i++)
            {
                p.Add(new Poker(pokers[i].Suit, pokers[i].Point));
            }
            return p;
        }

        private List<Poker> RemovePokers(List<Poker> pokers, List<Poker> pokersInPattern)
        {
            List<Poker> result = ClonePokers(pokers, 0, pokers.Count - 1);

            for (int i = result.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < pokersInPattern.Count; j++)
                {
                    if (result[i].Value == pokersInPattern[j].Value)
                    {
                        result.RemoveAt(i);
                        break;  //If don't break, result[i] will be assess after removed
                    }
                }
            }
            return result;

            //return pokers.Except(pokersInPattern).ToList();
        }

        public static string DisplayPokers(List<Poker> pokers)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < pokers.Count; i++)
            {
                sb.Append(pokers[i].ToString());
                if (i < pokers.Count - 1)
                    sb.Append("-");
            }

            return sb.ToString();
        }
    }
}
