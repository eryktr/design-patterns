using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Iterator
{
    interface IIterator<out T>
    {
        bool HasNext();
        T Next();
    }
}
