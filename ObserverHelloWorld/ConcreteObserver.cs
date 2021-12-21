
namespace ObserverHelloWorld
{
    internal class ConcreteObserver
    {
        private static int counter = 1;
        private readonly string name;
        private readonly ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject) {
            this.subject = subject;
            name = $"Observer_{counter++}";
            this.subject.Notify += Update;
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
            this.subject.Notify -= Update;
        }
    }
}
