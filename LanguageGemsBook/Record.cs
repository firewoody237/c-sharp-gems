namespace LanguageGemsBook;

// C# 9.0부터 사용 가능
// 불변 객체에서 빈번하게 이뤄지는 두 가지 연산(데이터 복사, 비교)을 편리하게 수행
record RTransaction
{
    public string From { get; init; }
    public string To { get; init; }
}

public class RecordClass
{
    public void method()
    {
        RTransaction rt1 = new RTransaction
        {
            From = "Alice", To = "Bob"
        };

        // `with` 키워드로 rt1에서 To만 Charlie로 변경하고 복사
        RTransaction rt2 = rt1 with { To = "Charlie" };

        // Record는 Equals를 자동 구현하여, 따로 구현하지 않아도 비교가 가능
        rt1.Equals(rt2);
    }
}