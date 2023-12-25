namespace LanguageGemsBook;

public class Exception
{
    public void method()
    {
        // C# 7.0 부터는 `throw`를 식으로 사용할 수 있다.
        int? num1 = null;
        int num2 = num1 ?? throw new InvalidArgumentException()
        {
            Argument = num1,
            Range = "0~255"
        };

        try
        {

        }
        catch (InvalidArgumentException e) when (e.ErrorNo < 0) // 예외 필터(Exception Filter)
        {

        }
        catch (InvalidArgumentException e) when (e.ErrorNo > 10)
        {
            
        }
    }
}

// 사용자 정의 예외
class InvalidArgumentException : System.Exception
{
    public InvalidArgumentException()
    {
        
    }

    public InvalidArgumentException(string message) : base(message)
    {
        
    }

    public object Argument
    {
        get;
        set;
    }

    public string Range
    {
        get;
        set;
    }

    public int ErrorNo
    {
        get;
        set;
    }
}