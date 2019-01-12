using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    class CardEnteredState : ATMState
    {
        public CardEnteredState(ATM context) : base(context)
        {
        }

        public override void InsertCard(Card card)
        {
            throw new InvalidOperationException();
        }

        public override void InsertPin(int pin)
        {
            if (_context.Card.Pin == pin)
            {
                _context.CurrentState = _context.PinEntered;
                Console.WriteLine("PIN OK");
            }
            else
            {
                Console.WriteLine("Incorrect PIN. Your card will be ejected.");
                EjectCard();
            }
        }

        public override void WithdrawMoney(int amount)
        {
            throw new InvalidOperationException();
        }

        public override void EjectCard()
        {
            Console.WriteLine("Your card has been ejected.");
            _context.CurrentState = _context.NoCard;
        }
    }
}
