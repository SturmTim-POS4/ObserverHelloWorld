namespace ObserverHelloWorld
{
    internal class ConcreteSubject
    {
        public event Action<int, string>? Notify;
        
        private int state = 0;

        public int State { get { return state; } set {
                state = value;
                Console.WriteLine($"{DateTime.Now:HH:mm:ss} -> new State {state}");
                Notify?.Invoke(state, "Seas");
        } }
    }
}
