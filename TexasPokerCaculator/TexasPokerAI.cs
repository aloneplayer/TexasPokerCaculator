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
            //3
            p = FindThreeOfAKind(this.pokersInPool);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.ThreeOfAKind, p);
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
                if (p[i].Point == p[i + 4].Point + 4)
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

            for (int i = 0; i < p.Count - 4; i++)
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

            for (int i = 0; i < p.Count - 3; i++)
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

            for (int i = 0; i < p.Count - 3; i++)
            {
                if (p[i].Point == p[i + 2].Point)
                {

                }
            }
            return null;
        }
        private List<Poker> FindTwoPair(List<Poker> pokers)
        {
            return null;
        }

        private List<Poker> FindOnePair(List<Poker> pokers)
        {
            List<Poker> p = this.SortPokersByPoint(pokers);

            for (int i = 0; i < p.Count - 2; i++)
            {
                if (pokers[i].Point == pokers[i + 1].Point)
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

        private List<Poker> ClonePokers(List<Poker> pokersInPool, int start, int end)
        {
            List<Poker> p = new List<Poker>();
            for (int i = start; i <= end; i++)
            {
                p.Add(new Poker(pokersInPool[i].Suit, pokersInPool[i].Point));
            }
            return p;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.pokersInPool.Count; i++)
            {
                sb.Append(pokersInPool[i].ToString());
                if (i < this.pokersInPool.Count - 1)
                    sb.Append("-");
            }

            return sb.ToString();
        }
    }
}
