namespace LanguageGemsBook;

public class Interface : IFight
{
    public string Name { get; set; }

    public void Atack(string message)
    {
        Console.WriteLine("Attack! " + message);
    }
}

public interface IFight
{
    string Name
    {
        get;
        set;
    }
    
    void Atack(string message);

    void Run(string message)
    {
        Console.WriteLine("Run " + message);
    }
}