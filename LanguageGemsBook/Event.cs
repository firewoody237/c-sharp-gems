namespace LanguageGemsBook;

delegate void EventHandler(string message);

// 객체에서 일어난 일, 사건을 표현하는 형식
public class Event
{
    static public void MyHandler(string message)
    {
        Console.WriteLine(message);
    }

    public void method()
    {
        MyNotifier notifier = new MyNotifier();
        notifier.SomethingHappend += new EventHandler(MyHandler);

        for (int i = 0; i < 30; i++)
        {
            notifier.DoSomething(i);
        }
    }
}

class MyNotifier
{
    public event EventHandler SomethingHappend;

    public void DoSomething(int number)
    {
        int temp = number % 10;
        if (temp != 0 && temp % 3 == 0)
        {
            SomethingHappend($"{number} : 짝");
        }
    }
}