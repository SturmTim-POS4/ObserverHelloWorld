using Microsoft.VisualBasic;

namespace ObserverHelloWorld
{
    internal class ConcreteSubject
    {
        //public event Action<object,DataEventArgs>? Notify;

        public event EventHandler<DataEventArgs>? Notify;
        
        private int state = 0;

        public int Counter { get; set; }

        public int State { get { return state; } set
        {
            Counter++;
                state = value;
                Console.WriteLine($"{DateTime.Now:HH:mm:ss} -> new State {state}");
                Notify?.Invoke(this, new DataEventArgs()
                {
                    Msg = "seas",
                    State = state,
                    Today = DateTime.Now
                });
        } }
    }
}
