namespace LanguageGems;

public class Nullable
{
    [Fact(DisplayName = "?.로 접근하는 객체의 멤버가 Null이면, Null을 반환한다.(C# 6.0)")]
    [Trait("Category", "?.")]
    public void Nullable1()
    {
        // Given
        string? nullableString = null;

        // When
        var result = nullableString?.Length;
        
        // Then
        Assert.Null(result);
    }

    [Fact(DisplayName = "?.로 접근하는 객체의 멤버가 Null이 아니면, 로직을 수행한다.(C# 6.0)")]
    [Trait("Category", "?.")]
    public void Nullable2()
    {
        // given
        string? nullableString = "MyValue";
        
        // when
        var result = nullableString?.Length;

        // then
        Assert.Equal(7, result);
        Assert.NotNull(result);
    }

    [Fact(DisplayName = "?[]로 접근하는 배열의 멤버가 Null이면, Null을 반환한다.(C# 6.0)")]
    [Trait("Category", "?[]")]
    public void NullableArray1()
    {
        // given
        List<int?> nullableList = null;

        // when
        var result = nullableList?[0].Value;

        // then
        Assert.Null(result);
    }

    [Fact(DisplayName = "?[]로 접근하는 배열의 멤버가 Null이 아니면, 로직을 수행한다.(C# 6.0)")]
    [Trait("Category", "?[]")]
    public void NullableArray2()
    {
        // given
        List<int?> nullableList = [1, 2, 3];

        // when
        var result1 = nullableList?[0].Value;
        var result2 = nullableList?[1].Value;
        var result3 = nullableList?[2].Value;

        // then
        Assert.Equal(1, result1);
        Assert.Equal(2, result2);
        Assert.Equal(3, result3);
    }
    
    [Fact(DisplayName = "!로 컴파일러에게 Null이 아님을 단언할 수 있다.(C# 6.0)")]
    [Trait("Category", "!")]
    public void NotNullAssert()
    {
        // given
        List<int?> nullableList = [1, 2, 3];

        // when
        var result1 = nullableList?[0]!.Value;
        var result2 = nullableList?[1]!.Value;
        var result3 = nullableList?[2]!.Value;

        // then
        Assert.Equal(1, result1);
        Assert.Equal(2, result2);
        Assert.Equal(3, result3);
    }

    [Fact(DisplayName = "??를 사용하면 Null이면 우변, Null이 아니면 좌변이 반환된다.")]
    [Trait("Category", "??")]
    public void NullCheck()
    {
        // given
        int? nullInt = null;
        int? notNullInt = 237;

        // when
        var result1 = nullInt ?? 1;
        var result2 = notNullInt ?? 1;

        // then
        Assert.Equal(1, result1);
        Assert.Equal(237, result2);
    }
}