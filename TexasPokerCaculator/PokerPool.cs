using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasPokerCaculator
{
    public class PokerPool
    {
        private List<PokerSlot> pokerSlots = new List<PokerSlot>();
        private int count;
        public PokerPool(int count)
        {
            this.count = count;
            for (int i = 0; i < count; i++)
            {
                pokerSlots.Add(new PokerSlot());
            }
        }

        public void InsterPoker(Poker.PokerSuits suit, int point)
        {
            for (int i = 0; i < count; i++)
            {
                if (pokerSlots[i].IsEmpty)
                {
                    pokerSlots[i].InsertPoker(suit, point);
                    break;
                }
            }
        }
        public void RemovePoker(Poker.PokerSuits suit, int point)
        {
            for (int i = 0; i < count; i++)
            {
                if (pokerSlots[i].Poker != null)
                {
                    if (pokerSlots[i].Poker.Suit == suit && pokerSlots[i].Poker.Point == point)
                    {
                        pokerSlots[i].Clear();
                        break;
                    }
                }
            }
        }
        public int Count
        {
            get { return this.count; }
        }

        public bool IsFull
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (pokerSlots[i].IsEmpty)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public PokerSlot this[int index]   // long is a 64-bit integer
        {
            // Read one byte at offset index and return it.
            get
            {
                return this.pokerSlots[index];
            }
        }
    }
}
