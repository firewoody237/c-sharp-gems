using System.Runtime.CompilerServices;

namespace LanguageGemsBook;

public class Attribute
{
    // Obsolete : 컴파일 경고
    [Obsolete("이 메소드는 폐기되었습니다.")]
    public void method1()
    {
        
    }
    
    // 호출자 정보 애트리뷰트
    // 메소드의 매개 변수에 사용
    public static void WriteLine(string message,
        [CallerFilePath] string file = "",  // 메소드가 호출된 소스 파일 정보
        [CallerLineNumber] int line = 0,  // 호출된 소스 파일 내의 행(Line) 번호
        [CallerMemberName] string member = "")  // 호출한 메소드 또는 프로퍼티의 이름
    {
        Console.WriteLine(
            $"\nFiilePath : {file}\nLine:{line}\nMemberName : {member}\nMessage : {message}");
    }
}

// 사용자 정의 애트리뷰트
[System.AttributeUsage( // 애트리뷰트의 애트리뷰트
    System.AttributeTargets.Class | System.AttributeTargets.Method,  // Attribute Target
    AllowMultiple=true)]  // AllowMultiple
class History : System.Attribute  // 상속
{
    private string programmer;
      
    public double Version
    {
        get;
        set;
    }
      
    public string Changes
    {
        get;
        set;
    }
      
    // 생성자
    public History(string programmer)
    {
        this.programmer = programmer;
        Version = 1.0;
        Changes = "First release";
    }
      
    public string Programmer
    {
        get { return programmer; }
    }
}

// 사용자 정의 애트리뷰트 사용
[History("Sean", Version=0.1, Changes="2017-11-01 Created class stub")]
class MyClass10
{
    public void Func()
    {
        Console.WriteLine("Func()");
    }
}