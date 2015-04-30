using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPokerCaculator
{
    public class PokerStack
    {
        [Flags]
        public enum PokerState
        {
            InStack = 0x01,
            OutStack = 0x2,
            HighLight = 0x4,
        }

        private Dictionary<int, PokerState> pokers = new Dictionary<int, PokerState>();

        public PokerStack()
        {
            InitPokerStack();
        }

        private void InitPokerStack()
        {
            pokers.Clear();
            for (int i = 0; i < 52; i++)
            {
                pokers.Add(i, PokerState.InStack);
            }
        }

        public void TakePoker(int value)
        {
            pokers[value] = PokerState.OutStack;
        }

        public void PutBackPoker(int value)
        {
            pokers[value] = PokerState.InStack;
        }

        public PokerState this[int index]   // long is a 64-bit integer
        {
            // Read one byte at offset index and return it.
            get
            {
                return this.pokers[index];
            }
            set 
            {
                this.pokers[index] = value;
            }
        }

        public void HighLightPoker(int suit, int point)
        {
            this.UnHighLightAll();
            int pokerValue = Poker.GetValue(suit, point);
            this[pokerValue] = this[pokerValue] | PokerState.HighLight;
        
        }
        public void UnHighLightAll()
        {
            for (int i = 0; i < 52; i++)
            {
                this[i] = this[i] & ~PokerState.HighLight;
            }
        }
    }
}
