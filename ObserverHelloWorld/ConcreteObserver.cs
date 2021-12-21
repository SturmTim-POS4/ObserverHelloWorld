
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

        public void Update(int state, string msg)
        {
            Console.WriteLine($"{this}: {state} ");
        }

        public void Exit()
        {
            this.subject.Notify -= Update;
        }
    }
}
