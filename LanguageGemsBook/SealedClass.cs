namespace LanguageGemsBook;

sealed class SealedClass
{
    // sealed class는 다른 class들이 상속할 수 없다.(컴파일 에러 발생)
}

class OpenClass : ParentClass
{
    public OpenClass(int min) : base(min)
    {
    }

    public sealed override void Initialize()
    {
        // sealed 가 붙으면 더이상 메소드 override 불가
    }
}