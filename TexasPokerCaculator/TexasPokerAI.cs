using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPokerCaculator
{
    public class TexasPokerAI
    {
        private List<Poker> currentPokers;

        public TexasPokerAI()
        {
            currentPokers = new List<Poker>();
        }

        public TexasPokerAI(PokerGroup commonPool, PokerGroup playerPool)
        {
            currentPokers = new List<Poker>();

            for (int i = 0; i < commonPool.Count; i++)
            {
                if (!commonPool[i].IsEmpty)
                {
                    currentPokers.Add(new Poker(commonPool[i].Poker.Value));
                }
            }
            for (int i = 0; i < playerPool.Count; i++)
            {
                if (!playerPool[i].IsEmpty)
                {
                    currentPokers.Add(new Poker(playerPool[i].Poker.Value));
                }
            }
        }
        public List<Poker> CurentPokers
        {
            get { return this.currentPokers; }
        }
        public PokerHand CalculatePattern()
        {
            List<Poker> p = FindRoyalFlush(this.currentPokers);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.RoyalFlush, p);
            }

            p = FindStraightFlush(this.currentPokers);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.StraightFlush, p);
            }

            p = FindStraight(this.currentPokers);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.Straight, p);
            }

            p = FindFlush(this.currentPokers);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.Flush, p);
            }

            // 4
            p = FindFourOfAKind(this.currentPokers);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.FourOfAKind, p);
            }

            //3+2
            p = FindFullHouse(this.currentPokers);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.FullHouse, p);

            }
            // 2+2
            p = FindTwoPair(this.currentPokers);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.TwoPairs, p);

            }

            //3
            p = FindThreeOfAKind(this.currentPokers);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.ThreeOfAKind, p);
            }
            // 1 pair
            p = FindOnePair(this.currentPokers);
            if (p != null)
            {
                return new PokerHand(PokerHand.TexasPattern.OnePair, p);
            }

            p = this.SortPokersByPoint(this.currentPokers);
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
            List<Poker> pSF = this.SortPokersBySuitThenPoint(pokers);
            for (int i = 0; i < pokers.Count - 4; i++)
            {
                if (pSF[i].Point == pSF[i + 1].Point + 1 &&
                    pSF[i].Point == pSF[i + 2].Point + 2 &&
                    pSF[i].Point == pSF[i + 3].Point + 3 &&
                    pSF[i].Point == pSF[i + 4].Point + 4 &&
                    pSF[i].Suit == pSF[i + 4].Suit)
                {
                    return ClonePokers(pSF, i, i + 4);
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

        private List<Poker> RemovePokers(List<Poker> pokers, List<Poker> pokersRemove)
        {
            List<Poker> result = ClonePokers(pokers, 0, pokers.Count - 1);

            for (int i = result.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < pokersRemove.Count; j++)
                {
                    if (result[i].Value == pokersRemove[j].Value)
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

        public List<PokerHand> PridectRoyalFlush1(List<Poker> currentPokers)
        {
            List<PokerHand> pokerHands = new List<PokerHand>();
            List<Poker> allPoksers = this.CreateAllPokers();

            List<Poker> outPoksers = this.RemovePokers(allPoksers, currentPokers);

            for (int i = 0; i < outPoksers.Count; i++)
            {
                List<Poker> pridectPokers = ClonePokers(currentPokers);
                pridectPokers.Add(outPoksers[i]);

                List<Poker> handPokers = FindRoyalFlush(pridectPokers);
                if (handPokers != null)
                {
                    pokerHands.Add(new PokerHand(PokerHand.TexasPattern.RoyalFlush, handPokers));
                }
            }
            return pokerHands;
        }


        private List<Poker> ClonePokers(List<Poker> sourcePokers)
        {
            List<Poker> pokers = new List<Poker>();
            for (int i = 0; i < sourcePokers.Count; i++)
            {
                pokers.Add(new Poker(sourcePokers[i].Value));
            }
            return pokers;
        }

        private List<Poker> ClonePokers(List<Poker> source1, List<Poker> source2)
        {
            List<Poker> pokers = new List<Poker>();
            for (int i = 0; i < source1.Count; i++)
            {
                pokers.Add(new Poker(source1[i].Value));
            }

            for (int i = 0; i < source2.Count; i++)
            {
                pokers.Add(new Poker(source2[i].Value));
            }
            return pokers;
        }
        private List<Poker> CreateAllPokers()
        {
            List<Poker> pokers = new List<Poker>();
            for (int i = 0; i < 52; i++)
            {
                pokers.Add(new Poker(i));
            }
            return pokers;
        }
    }
}
