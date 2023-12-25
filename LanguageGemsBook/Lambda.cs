namespace LanguageGemsBook;

delegate int Calculate(int a, int b);

delegate void DoSomething();

public class Lambda
{
    public void method()
    {
        // 식 형식의 람다
        Calculate calc = (a, b) => a + b;
        
        // 문 형식의 람다
        DoSomething DoIt = () =>
        {
            Console.WriteLine("Print Something");
        };
        DoIt();
        
        // Func 대리자
        // 매번 대리자(delegate)를 선언해야 하는 불편 제거
        // 반환 값이 있는 익명 메소드/무명 함수용 대리자
        // 마지막 형식 매개변수는 반환 타입
        Func<int> func1 = () => 10;
        func1();
        Func<int, int> func2 = (x) => x + 2;
        func2(1);
        Func<int, int, int> func3 = (x, y) => x + y;
        func3(1, 2);
        
        // Action 대리자
        // 반환 형식이 없고 입력 매개변수를 위해 선언
        Action act1 = () => Console.WriteLine("Action");
        act1();
        int result = 0;
        Action<int> act2 = (x) => result = x + x;
        act2(3);
        Action<double, double> act3 = (x, y) =>
        {
            double pi = x / y;
            Console.WriteLine(pi);
        };
        act3(1, 2);
    }
}