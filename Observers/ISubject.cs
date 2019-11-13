using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    public interface ISubject
    {
        abstract void RegisterObserver(IObserver observer);
        abstract void RemoveObserver(IObserver observer);

    }
}
