using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Card
    {
        // Times kartas, apo 2 eos Ace
        public enum Value
        {
            Two = 2, Three, Four, Five, Six, Seven, Eight,
            Nine, Ten, Jack, Queen, King, Ace
        }
        // enum list of suits
        public enum Suit
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs

        }
        
        public Value myValue { get; set; }

        public Suit mySuit { get; set; }

    }
}
