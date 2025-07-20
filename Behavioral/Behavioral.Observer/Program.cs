public interface IObserver
{
    void Update(string message);
}

public interface ISender
{
    void Send(string message);
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
}

public class Observer1 : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Message from observer 1 : {message}");
    }
}

public class Observer2 : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Message from observer 2 : {message}");
    }
}

public class Sender : ISender
{
    private List<IObserver> _observers = new List<IObserver>();
    private readonly object _lock = new object();
    public void AddObserver(IObserver observer)
    {
        lock(_lock)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }
    }

    public void Send(string message)
    {
        List<IObserver> observerSnapshot;
        lock (_lock)
        {
            observerSnapshot = new List<IObserver>(_observers);
        }
        foreach (IObserver observer in observerSnapshot) {
          observer.Update(message);
        }
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var ob1 = new Observer1();
        var ob2 = new Observer2();

        var sender = new Sender();
        sender.AddObserver(ob1);
        sender.AddObserver(ob2);

        sender.Send("Hey all");
    }
}