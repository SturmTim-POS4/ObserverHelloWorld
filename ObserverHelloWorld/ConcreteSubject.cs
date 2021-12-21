using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverHelloWorld
{
    internal class ConcreteSubject : Subject
    {
        private int state = 0;

        public int State { get { return state; } set {
                state = value;
                Console.WriteLine($"{DateTime.Now:HH:mm:ss} -> new State {state}");
                Notify();
            } }
    }
}
