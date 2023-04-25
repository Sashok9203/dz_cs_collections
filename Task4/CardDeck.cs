using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class CardDeck : IEnumerable<Card>
    {
        private Queue<Card> deck = new();

        public CardDeck()
        {
            for (int i = 0; i <= (int)Number.Ace; i++)
            {
                for (int k = 0; k <= (int)Suits.Spades; k++)
                    deck.Enqueue(new Card((Suits)k, (Number)i));
            }
        }

        public Card GetCard() => deck.Dequeue();

        public bool IsEmpty => deck.Count == 0;

        public Card[] GetSix()
        {
            int  count = 0;
            List<Card> six = new ();
            while (count != 6 && !IsEmpty)
            {
                six.Add(deck.Dequeue());
                count++;
            }
            return six.ToArray();
        }

        public void Shuffle()
        {
            Card[] tmp = deck.ToArray();
            for (int i = 0; i < tmp.Length; i++)
            {
                Random rand = new();
                int rnd = rand.Next(0, tmp.Length);
                (tmp[i], tmp[rnd]) = (tmp[rnd], tmp[i]);
            }
            deck = new(tmp);
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return deck.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return deck.GetEnumerator();
        }
    }
}
