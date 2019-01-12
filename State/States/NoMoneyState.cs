using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    class NoMoneyState : ATMState
    {
        public NoMoneyState(ATM context) : base(context)
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
            throw new InvalidOperationException();
        }

        public override void EjectCard()
        {
            throw new InvalidOperationException();
        }
    }
}
