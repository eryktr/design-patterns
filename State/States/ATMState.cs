using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    abstract class ATMState
    {
        protected ATM _context;

        protected ATMState(ATM context)
        {
            _context = context;
        }

        public abstract void InsertCard(Card card);
        public abstract void InsertPin(int pin);
        public abstract void WithdrawMoney(int amount);
        public abstract void EjectCard();

        public void Refill(int amount)
        {
            _context.Amount += amount;
            if (_context.CurrentState == _context.NoMoney)
                _context.CurrentState = _context.NoCard;
        }
    }
}