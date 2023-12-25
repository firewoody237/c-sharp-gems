namespace LanguageGemsBook;

// dynamic은 런타임에 형식 검사가 이루어진다.(다른 타입은 컴파일 단계)
// 컴파일러가 dynamic을 만나면 형식 검사를 프로그램 실행때로 미룸
public class Dynamic
{
    public void method()
    {
        dynamic obj = new MyClass5();
        obj.FuncAAA();
        obj.FuncBBB(); // 선언 되지 않았지만 컴파일 검사를 피해가기 때문에 사용 가능
        
        // 덕 타이핑
        dynamic[] arr = new dynamic[] { new Duck(), new Mallard(), new Robot() };
        foreach (dynamic duck in arr)
        {
            Console.WriteLine(duck.GetType());
            duck.Walk();
            duck.Swim();
            duck.Quack();
        }
    }
}

class MyClass5
{
    public void FuncAAA()
    {
        
    }
}

// dynamic을 사용하면 덕 타이핑 가능
// "오리처럼 걷고 오리처럼 헤엄치며 오리처럼 꽉꽉 거리는 새를 봤을 때, 나는 그 새를 오리라고 부른다."
class Duck
{
    public void Walk()
    {
        
    }

    public void Swim()
    {
        
    }

    public void Quack()
    {
        
    }
}

class Mallard : Duck
{
    
}

class Robot
{
    public void Walk()
    {
        
    }

    public void Swim()
    {
        
    }

    public void Quack()
    {
        
    }
}