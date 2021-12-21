namespace ObserverHelloWorld;

public class DataEventArgs : EventArgs
{
    public int State { get; set; }

    public string Msg { get; set; }

    public DateTime Today { get; set; }
}