namespace LanguageGems;

public class Class
{
    [Fact(DisplayName = "IClonable을 구현하여 깊은 복사를 할 수 있다.")]
    [Trait("Category", "Copy")]
    public void ClassClone()
    {
        // given
        MyClass myClass = new MyClass(1, 2);

        // when
        MyClass copiedMyClass = (MyClass) myClass.Clone();

        // then
        Assert.Equal(myClass.MyField1, copiedMyClass.MyField1);
        Assert.Equal(myClass.MyField2, copiedMyClass.MyField2);
        Assert.False(myClass == copiedMyClass);
    }
}

sealed class MyClass : ICloneable
{
    public int MyField1;
    public int MyField2;

    public MyClass()
    {
        
    }

    public MyClass(int field1, int field2) : this() // this()는 자기 자신의 생성자를 뜻한다.
    {
        MyField1 = field1;
        MyField2 = field2;
    }

    public object Clone()
    {
        MyClass newCopy = new MyClass();
        newCopy.MyField1 = this.MyField1;
        newCopy.MyField2 = this.MyField2;
        return newCopy;
    }
}