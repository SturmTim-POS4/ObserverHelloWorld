namespace ObserverHelloWorld
{
    internal class ConcreteSubject
    {
        public delegate void NotifyFunction();

        public event NotifyFunction? Notify;
        
        private int state = 0;

        public int State { get { return state; } set {
                state = value;
                Console.WriteLine($"{DateTime.Now:HH:mm:ss} -> new State {state}");
                if (Notify != null) Notify();
        } }
    }
}
