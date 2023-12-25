namespace LanguageGemsBook;

public class Generic<T> where T : class // T를 class 형식으로 제한
{
    private T[] array;

    public T GetElement(int index)
    {
        return array[index];
    }
}