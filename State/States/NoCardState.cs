using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    class NoCardState : ATMState
    {
        public NoCardState(ATM context) : base(context)
        {
        }

        public override void InsertCard(Card card)
        {
            Console.WriteLine("Card accepted.");
            _context.Card = card;
            _context.CurrentState = _context.CardEntered;

        }

        public override void InsertPin(int pin)
        {
            throw new InvalidOperationException();
        }

        public override void WithdrawMoney(int amount)
        {
            throw new InvalidOperationException();
        }

        public override void EjectCard()
        {
            throw new InvalidOperationException();
        }
    }
}
