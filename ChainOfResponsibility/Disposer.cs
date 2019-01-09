using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    abstract class Disposer
    {
        public Disposer Next { get; private set; }
        public int Counter { get; protected set; }
        public int Value { get; protected set; }

        public abstract void Process(ref int dollars, ref int cents);
        public abstract void PrintMessage();

        protected Disposer(int value) => Value = value;

        public void SetNext(Disposer disposer) => Next = disposer;
        
  
        public void Dispose(int dollars, int cents)
        {
            Process(ref dollars, ref cents);
            PrintMessage();
            Next?.Dispose(dollars, cents);
        }

    }
}
