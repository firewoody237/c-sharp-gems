namespace LanguageGems;

public class Type
{
    [Fact(DisplayName = "Parse() 사용 시 변환에 실패하면 예외를 던지고 멈춘다.")]
    [Trait("Category", "Parse()")]
    public void ParseException()
    {
        // given
        string stringCanBeConvertedToInt = "237";
        string stringCanNotBeConvertedToInt = "237A";

        // when

        // then
        Assert.Equal(237, Int32.Parse(stringCanBeConvertedToInt));
        Assert.Throws<FormatException>(() => Int32.Parse(stringCanNotBeConvertedToInt));
    }

    [Fact(DisplayName = "TryParse()시 실패하면 False를 반환하고, out 변수는 무조건 0이 된다.")]
    [Trait("Category", "TryParse()")]
    public void TryParseFail()
    {
        // given
        string stringCanNotBeConvertedToInt = "237A";

        // when
        int canNotBeInt = 1;
        bool result = Int32.TryParse(stringCanNotBeConvertedToInt, out canNotBeInt);

        // then
        Assert.False(result);
        Assert.Equal(0, canNotBeInt);
    }
}