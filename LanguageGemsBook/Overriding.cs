namespace LanguageGemsBook;

public class Overriding : ParentClass
{
    public Overriding(int min) : base(min)
    {
        
    }
    
    public override void Initialize()
    {
        
    }

    public new void MethodHiding()
    {
        // Method Hiding 파생 클래스에서 구현된 버전만 보여진다.
    }
}

public partial class ParentClass
{
    // readonly로 전용 필드 선언(읽기만 가능)
    private readonly int min;

    public ParentClass(int min)
    {
        this.min = min;
    }
    
    public virtual void Initialize()
    {
        // 기반 클래스에서 오버라이딩 할 메소드를 미리 virtual로 한정
        // private으로 선언하면 오버라이딩 불가
    }

    public void MethodHiding()
    {
        
    }
}