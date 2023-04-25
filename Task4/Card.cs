using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    enum Suits
    {
        Diamonds,
        Hearts,
        Club,
        Spades
    };
    enum Number
    {
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    };
    internal class Card 
    {
        public Suits Suits { get; }
        public Number Number { get; }
       
        public Card(Suits suit, Number num)  { Suits = suit;Number = num; }
        public override string ToString() => $"{Number} {Suits}";
    }
}
