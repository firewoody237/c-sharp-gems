namespace LanguageGemsBook;

delegate void Notify(string message);

class Notifier
{
    public Notify EventOccured;
}

class EventListener
{
    private string name;

    public EventListener(string name)
    {
        this.name = name;
    }

    public void SomethingHappend(string message)
    {
        Console.WriteLine($"{name}.SomethingHappend : {message}");
    }
}

public class DelegateChain
{
    public void main()
    {
        Notifier notifier = new Notifier();
        EventListener listener1 = new EventListener("Listener1");
        EventListener listener2 = new EventListener("Listener2");
        EventListener listener3 = new EventListener("Listener3");

        notifier.EventOccured += listener1.SomethingHappend;
        notifier.EventOccured += listener2.SomethingHappend;
        notifier.EventOccured += listener3.SomethingHappend;

        notifier.EventOccured("You've got mail.");
    }
}