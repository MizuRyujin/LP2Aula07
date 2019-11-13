namespace Observers
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();

            IObserver obs1 = new ConcreteObserver();
            IObserver obs2 = new ObserverToText("lp2.txt");


            subject.RegisterObserver(obs1);
            subject.RegisterObserver(obs2);


            subject.Execute();
        }
    }
}
