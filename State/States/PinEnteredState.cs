using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    class PinEnteredState : ATMState
    {
        public PinEnteredState(ATM context) : base(context)
        {
        }

        public override void InsertCard(Card card)
        {
            throw new InvalidOperationException();
        }

        public override void InsertPin(int pin)
        {
            throw new InvalidOperationException();
        }

        public override void WithdrawMoney(int amount)
        {
            if (amount > _context.Amount)
            {
                Console.WriteLine("The ATM has too little funds. Your card will be ejected.");
                EjectCard();
            }
            else if (amount > _context.Card.Amount)
            {
                Console.WriteLine("You don't have enough funds. Your card will be ejected.");
                EjectCard();
            }

            _context.Amount -= amount;
            _context.Card.Amount -= amount;

            if (_context.Amount == 0)
                _context.CurrentState = _context.NoMoney;

            Console.WriteLine("Money withdraw successfully. Your card will be ejected.");
            EjectCard();
        }

        public override void EjectCard()
        {
            Console.WriteLine("Your card has been ejected.");
            _context.CurrentState = _context.NoCard;
        }
    }
}
