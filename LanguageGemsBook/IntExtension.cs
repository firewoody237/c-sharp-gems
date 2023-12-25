namespace LanguageGemsBook;

public static class IntExtension
{
    public static string IntToString(this int num, string extraStr)
    {
        return num.ToString() + " " + extraStr;
    }
}

public class IntExtensionUse
{
    private int num1 = 237;

    public void method()
    {
        num1.IntToString("Two Three Seven");
    }
}