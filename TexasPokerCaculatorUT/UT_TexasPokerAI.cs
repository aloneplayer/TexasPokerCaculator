using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TexasPokerCaculator;
using System.Collections.Generic;

namespace TexasPokerCaculatorUT
{
    [TestClass]
    public class UT_TexasPokerAI
    {
        TexasPokerAI ai;
        List<Poker> pokers;

        [TestInitialize()]
        public void Initialize()
        {
            pokers = new List<Poker>
            {
                new Poker(Poker.PokerSuits.Clubs, 3),
                new Poker(Poker.PokerSuits.Spades, 5),
                new Poker(Poker.PokerSuits.Hearts, 5),
                new Poker(Poker.PokerSuits.Diamonds, 10),
                new Poker(Poker.PokerSuits.Spades, 0),
                new Poker(Poker.PokerSuits.Clubs, 8),
                new Poker(Poker.PokerSuits.Spades, 6),
            };

            PokerGroup commonPool = new PokerGroup(5);
            commonPool.InsterPoker(Poker.PokerSuits.Clubs, 3);
            commonPool.InsterPoker(Poker.PokerSuits.Spades, 5);
            commonPool.InsterPoker(Poker.PokerSuits.Hearts, 5);
            commonPool.InsterPoker(Poker.PokerSuits.Diamonds, 10);
            commonPool.InsterPoker(Poker.PokerSuits.Spades, 0);

            PokerGroup playerPool = new PokerGroup(2);
            playerPool.InsterPoker(Poker.PokerSuits.Clubs, 8);
            playerPool.InsterPoker(Poker.PokerSuits.Spades, 6);


            ai = new TexasPokerAI(commonPool, playerPool);
        }

        [TestCleanup()]
        public void Cleanup()
        {
        }

        [TestMethod]
        public void SortPokersByPoint_Test()
        {
            PrivateObject obj = new PrivateObject(ai);
            List<Poker> result = (List<Poker>)obj.Invoke("SortPokersByPoint", pokers);

            string s = TexasPokerAI.DisplayPokers(result);
            Assert.AreEqual("方块Q-梅花10-黑桃8-黑桃7-红桃7-梅花5-黑桃2", s);

        }

        [TestMethod]
        public void SortPokerBySuitThenPoint_Test()
        {
            PrivateObject obj = new PrivateObject(ai);
            List<Poker> result = (List<Poker>)obj.Invoke("SortPokersBySuitThenPoint", pokers);
            string s = TexasPokerAI.DisplayPokers(result);
            Assert.AreEqual("黑桃8-黑桃7-黑桃2-红桃7-方块Q-梅花10-梅花5", s);

        }
        [TestMethod]
        public void SortPokerByPointThenSuit_Test()
        {
            PrivateObject obj = new PrivateObject(ai);
            List<Poker> result = (List<Poker>)obj.Invoke("SortPokersByPointThenSuit", pokers);
            string s = TexasPokerAI.DisplayPokers(result);
            Assert.AreEqual("方块Q-梅花10-黑桃8-黑桃7-红桃7-梅花5-黑桃2", s);
        }


        [TestMethod]
        public void DisplayPokers_Test()
        {
            string s = TexasPokerAI.DisplayPokers(pokers);
            Assert.AreEqual("梅花5-黑桃7-红桃7-方块Q-黑桃2-梅花10-黑桃8", s);
        }

        [TestMethod]
        public void RemovePokers_Test()
        {
            List<Poker> pokers = new List<Poker>
            {
                new Poker(Poker.PokerSuits.Diamonds, 10),
                new Poker(Poker.PokerSuits.Hearts,11 ),
                new Poker(Poker.PokerSuits.Diamonds,12 ),
                new Poker(Poker.PokerSuits.Spades, 8),
                new Poker(Poker.PokerSuits.Hearts, 8)
             
            };

            List<Poker> pokers2 = new List<Poker>
            {
                new Poker(Poker.PokerSuits.Spades, 8),
                new Poker(Poker.PokerSuits.Hearts, 8)
            };


            PrivateObject obj = new PrivateObject(ai);
            List<Poker> result = (List<Poker>)obj.Invoke("RemovePokers", pokers, pokers2);

            string s = TexasPokerAI.DisplayPokers(result);
            Assert.AreEqual("方块Q-红桃K-方块A", s);
        }
    }
}
