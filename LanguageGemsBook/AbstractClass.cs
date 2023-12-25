namespace LanguageGemsBook;

abstract class AbstractClass
{
    public abstract string Name
    {
        get;
        set;
    }
    public abstract void SomeMethod();
}

class Derived : AbstractClass
{
    public override string Name { get; set; }

    public override void SomeMethod() // 무조건 구현해야 함.
    {
        throw new NotImplementedException();
    }
}