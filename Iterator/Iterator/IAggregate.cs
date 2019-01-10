using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Iterator
{
    interface IAggregate<out T>
    {
        IIterator<T> GetIterator();
    }
}
