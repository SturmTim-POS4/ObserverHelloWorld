global using ObserverLib;

namespace ObserverHelloWorld
{
    internal class ConcreteObserver : IObserver
    {
        private static int count = 1;
        private readonly string name;
        private readonly ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject concrete) {
            this.subject = concrete;
            name = $"Observer_{count++}";
            subject.Attach(this);
        }

        public override string ToString()
        {
            return name;
        }

        public void Update()
        {
            int nr = subject.State;
            Console.WriteLine($"{DateTime.Now:HH:mm:ss}: {name} ");
        }

        public void Exit()
        {
            subject.Detach(this);
        }
    }
}
