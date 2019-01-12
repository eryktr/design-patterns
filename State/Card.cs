using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Card
    {
        public int Pin { get; private set; }
        public int Amount { get; set; }

        public Card(int pin)
        {
            Pin = pin;
            Amount = 200;
        }


    }
}
