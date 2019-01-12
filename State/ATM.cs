using System;
using System.Collections.Generic;
using System.Text;
using State.States;

namespace State
{
    class ATM
    {
        public readonly ATMState NoCard;
        public readonly ATMState CardEntered;
        public readonly ATMState NoMoney;
        public readonly ATMState PinEntered;
        public int Amount { get; set; }
        public Card Card { get; set; }

        public ATMState CurrentState { get; set; }

        public ATM()
        {
            NoCard = new NoCardState(this);
            CardEntered = new CardEnteredState(this);
            NoMoney = new NoMoneyState(this);
            PinEntered = new PinEnteredState(this);
            CurrentState = NoCard;
            Amount = 1000;
        }

        public void InsertCard(Card card)
        {
            CurrentState.InsertCard(card);
        }

        public  void InsertPin(int pin)
        {
            CurrentState.InsertPin(pin);
        }

        public void WithdrawMoney(int amount)
        {
            CurrentState.WithdrawMoney(amount);
        }

        public void EjectCard()
        {
            CurrentState.EjectCard();
        }

    }
}
