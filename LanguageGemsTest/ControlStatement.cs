using System.Diagnostics;

namespace LanguageGems;

public class ControlStatement
{
    [Fact(DisplayName = "switch문에서 case에 데이터 타입을 조건으로 사용할 수 있다.(C# 7.0)")]
    [Trait("Category", "switch")]
    public void SwitchType()
    {
        // given
        object myObject = 237;
        object? result;

        // when
        switch(myObject)
        {
            case int i:
                result = i;
                break;
            case double d:
                result = d;
                break;
            case string s:
                result = s;
                break;
            default:
                result = null;
                break;
        }

        // then
        Assert.Equal(237, result);
        Assert.True(result! is int);
    }

    [Fact(DisplayName = "switch는 식으로 간주하여 결과를 변수에 대입이 가능하다.")]
    [Trait("Category", "switch")]
    public void SwitchExpression()
    {
        // given
        int score = 80;

        // when
        string grade = score switch
        {
            90 => "A",
            80 => "B",
            70 => "C",
            _ => "F"
        };

        // then
        Assert.Equal("B", grade);
    }
    
    [Fact(DisplayName = "switch에서 when으로 추가 조건 검사가 가능하다.")]
    [Trait("Category", "switch")]
    public void SwitchWhen()
    {
        // given
        int score = 80;
        bool repeated = true;

        // when
        string grade = score switch
        {
            90 => "A",
            80 when repeated == true => "B+",
            80 => "B",
            70 => "C",
            _ => "F"
        };

        // then
        Assert.Equal("B+", grade);
    }
}