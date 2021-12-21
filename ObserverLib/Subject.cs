namespace ObserverLib;
    public class Subject
    {
        private readonly List<IObserver> _observers = new();

        public void Attach(IObserver observer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"+++++++ Atached {observer}");
            Console.ForegroundColor = ConsoleColor.White;
            _observers.Add(observer);
            
        }

        public void Detach(IObserver observer)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"------- Detached {observer}");
            Console.ForegroundColor = ConsoleColor.White;
            _observers.Remove(observer);
        }

        public void Notify()
        {
        _observers.ForEach(x => x.Update());
        }
}
