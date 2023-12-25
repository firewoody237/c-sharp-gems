namespace LanguageGemsBook;

// C#에서 배열은 .NET의 CTS(Common Type System)에서 `System.Array` 형식을 기반으로 파생되었다.
public class Array
{
    public void method()
    {
        int[] scores = new int[5];
        scores[0] = 10;
        scores[1] = 20;
        scores[2] = 30;
        scores[^2] = 40; // `^`를 사용해서 역 인덱스 사용 가능

        System.Index last = ^1;
        scores[last] = 50;

        // 배열 분할
        int[] slice1 = scores[..3]; // 0, 1, 2
        int[] slice2 = scores[1..]; // 1, 2, 3, 4
        int[] slice3 = scores[..]; // 0, 1, 2, 3, 4
        int[] slice4 = scores[1..3]; // 1, 2
        
        //2차원 배열
        int[,] deminsion2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
    }
}