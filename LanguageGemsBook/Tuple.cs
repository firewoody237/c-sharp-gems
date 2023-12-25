namespace LanguageGemsBook;

public class Tuple
{
    public void method()
    {
        var smith = (job: "Student", age: 18);
        var (newJob, newAge) = smith;
        var (newJob1, newAge1) = ("Adult", 30);

        var discountRate = smith switch
        {
            ("Student", int age) when age < 18 => 0.2,
            ("Student", _) => 0.1, // 특정 필드를 무시하고 싶다면 `_` 사용
            ("Adult", int age) when age < 18 => 0.1,
            ("Adult", _) => 0.05,
            _ => 0,
        };
    }
}