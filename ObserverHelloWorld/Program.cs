using ObserverHelloWorld;

var subject = new ConcreteSubject();

var firstObserver = new ConcreteObserver(subject);
var secondObserver = new ConcreteObserver(subject);

for (int i = 0; i < 10; i++)
{
    Thread.Sleep(1000);

    if (i == 3)
    {
        secondObserver = new(subject);
    }

    subject.State = i;

    if ( i == 4)
    {
        firstObserver.Exit();
    }
}

Console.ReadKey();
