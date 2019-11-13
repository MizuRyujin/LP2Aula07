using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    public interface IObserver
    {
        abstract void Update(ISubject subject);
    }
}
