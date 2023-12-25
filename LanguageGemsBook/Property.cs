namespace LanguageGemsBook;

public class Property
{
    public string Name
    {
        get;
        set;
    } // 자동 구현 프로퍼티

    public int Age
    {
        get;
        set;
    } = 0; // C# 7.0부터 자동 구현 프로퍼티 선언과 초기화 수행 가능

    public string Job
    {
        get;
        init; // C# 9.0부터 객체를 초기화 할 때만 외부에서 프로퍼티 변경이 가능
    }
}

public class MyClass
{
    // 객체를 생성할 때 프로퍼티를 통해 각 필드 초기화
    // Target Typed New로 new()만으로 객체 생성 가능
    private Property _myProperty = new()
    {
        Name = "Smith",
        Age = 13
    };
}