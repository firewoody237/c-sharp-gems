
namespace LanguageGems;

public class Method
{
    [Fact(DisplayName = "ref 키워드로 참조 매개변수 사용이 가능하다.")]
    [Trait("Category", "Method Parameter")]
    public void MethodParameterRef()
    {
        // given
        var swap1 = 1;
        var swap2 = 2;
        void Swap(ref int num1, ref int num2)
        {
            (num2, num1) = (num1, num2);
        }

        // when
        Swap(ref swap1, ref swap2);

        // then
        Assert.Equal(2, swap1);
        Assert.Equal(1, swap2);
    }

    [Fact(DisplayName = "ref 키워드로 참조 반환값 사용이 가능하다.")]
    [Trait("Category", "ref")]
    public void MethodReturnRef()
    {
        // given
        Weapon myWeapon = new Weapon();
        ref int refDamage = ref myWeapon.GetDamage();
        int damage = myWeapon.GetDamage();
        
        // when
        refDamage = 5;

        // then
        Assert.Equal(5, refDamage);
        Assert.Equal(5, myWeapon.GetDamage());
        Assert.Equal(10, damage);
    }

    [Fact(DisplayName = "out 키워드로 복수개의 값을 반환할 수 있다.")]
    [Trait("Category", "Method Parameter")]
    public void MethodOutParameter()
    {
        // given
        void MyMethod(int num1, int num2, out int plus, out int minus)
        {
            plus = num1 + num2;
            minus = num1 - num2;
            // out 변수는 값이 수정되지 않으면 컴파일 에러가 발생한다.
        }

        int one = 1;
        int two = 2;
        int result1 = 0; // out 변수는 선언부 생략 가능
        int result2 = 0; // out 변수는 선언부 생략 가능

        // when
        MyMethod(one, two, out result1, out result2);

        // then
        Assert.Equal(3, result1);
        Assert.Equal(-1, result2);
    }

    [Fact(DisplayName = "params를 사용하여 Method에서 가변인수를 받을 수 있다.")]
    [Trait("Category", "Method Parameter")]
    public void MethodParams()
    {
        // given
        int Sum(params int[] args)
        {
            int sum = 0;
            for (int i=0; i < args.Length; i++)
            {
                sum += args[i];
            }

            return sum;
        }

        // when
        var result10 = Sum(4, 6);
        var result15 = Sum(4, 5, 6);
        var result27 = Sum(4, 5, 6, 12);

        // then
        Assert.Equal(10, result10);
        Assert.Equal(15, result15);
        Assert.Equal(27, result27);
    }

    [Fact(DisplayName = "Named Argument로 메서드에 이름을 붙여 사용할 수 있다.")]
    [Trait("Category", "Method Parameter")]
    public void MethodNamedArgument()
    {
        // given
        string PrintProfile(string name, string phone)
        {
            return $"{name}, {phone}";
        }

        // when
        string result = PrintProfile(name: "Firewoody", phone: "010-0000-1111");

        // then
        Assert.Equal("Firewoody, 010-0000-1111", result);
    }

    [Fact(DisplayName = "메소드 매개변수의 기본값 설정이 가능하다.")]
    [Trait("Category", "Method Parameter")]
    public void MethodDefaultParameter()
    {
        // given
        string PrintProfile(string name = "Empty", string phone = "Empty")
        {
            return $"{name}, {phone}";
        }

        // when
        var result = PrintProfile();

        // then
        Assert.Equal("Empty, Empty", result);
    }
}

class Weapon
{
    private int damage = 10;

    public ref int GetDamage()
    {
        return ref damage;
    }
}