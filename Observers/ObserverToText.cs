using System;
using System.IO;

namespace Observers
{
    class ObserverToText : IObserver
    {
        private string fileName;

        public ObserverToText(string fileName)
        {
            this.fileName = fileName;
        }

        void IObserver.Update(ISubject subject)
        {
            File.AppendAllText(
                fileName, (subject as ConcreteSubject).LastKey.ToString());
        }
    }
}
