using System;
using System.Collections.Generic;

namespace Observers
{
    public class ConcreteSubject : ISubject
    {
        public ConsoleKey LastKey { get; private set; }

        private ICollection<IObserver> observers;

        public ConcreteSubject()
        {
            observers = new HashSet<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Execute()
        {
            while(true)
            {
                LastKey = Console.ReadKey(true).Key;

                if (LastKey == ConsoleKey.Escape) break;
                
                foreach(IObserver obs in observers)
                {
                    obs.Update(this);
                }
            }
        }
    }
}
