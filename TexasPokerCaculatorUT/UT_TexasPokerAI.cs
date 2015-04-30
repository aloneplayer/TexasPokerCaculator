using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TexasPokerCaculator;

namespace TexasPokerCaculatorUT
{
    [TestClass]
    public class UT_TexasPokerAI
    {
        TexasPokerAI ai; 

        [TestInitialize()]
        public void Initialize() 
        {
            PokerPool commonPool = new PokerPool(5);
            commonPool.InsterPoker(Poker.PokerSuits.Clubs, 3);
            commonPool.InsterPoker(Poker.PokerSuits.Spades, 5);
            commonPool.InsterPoker(Poker.PokerSuits.Hearts, 5);
            commonPool.InsterPoker(Poker.PokerSuits.Diamonds, 10);
            commonPool.InsterPoker(Poker.PokerSuits.Spades, 0);

            PokerPool playerPool = new PokerPool(2);
            playerPool.InsterPoker(Poker.PokerSuits.Clubs, 8);
            playerPool.InsterPoker(Poker.PokerSuits.Spades, 6);


            ai = new TexasPokerAI(commonPool, playerPool);
        }

        [TestCleanup()]
        public void Cleanup() 
        { 
        }

        [TestMethod]
        public void SortPokersByPoints_Test()
        {
            PrivateObject obj = new PrivateObject(ai);
            var retVal = obj.Invoke("SortPokersByPoints");
          
            
            string s = ai.ToString();
            Assert.AreEqual("方块Q-梅花10-黑桃8-黑桃7-红桃7-梅花5-黑桃2", s);
   
        }

        [TestMethod]
        public void SortPokerBySuitThenPoint_Test()
        {
            PrivateObject obj = new PrivateObject(ai);
            var retVal = obj.Invoke("SortPokerBySuitThenPoint");


            string s = ai.ToString();
            Assert.AreEqual("黑桃8-黑桃7-黑桃2-红桃7-方块Q-梅花10-梅花5", s);

        }
        [TestMethod]
        public void SortPokerByPointThenSuit_Test()
        {
            PrivateObject obj = new PrivateObject(ai);
            var retVal = obj.Invoke("SortPokerByPointThenSuit");


            string s = ai.ToString();
            Assert.AreEqual("方块Q-梅花10-黑桃8-黑桃7-红桃7-梅花5-黑桃2", s);
        }


        [TestMethod]
        public void ToString_Test()
        {
            string s = ai.ToString();
            Assert.AreEqual("梅花5-黑桃7-红桃7-方块Q-黑桃2-梅花10-黑桃8", s);
        }
    }
}
