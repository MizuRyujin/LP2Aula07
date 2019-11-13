using System;

namespace Observers
{
    public class ConcreteObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine((subject as ConcreteSubject).LastKey);
        }
    }
}
