namespace LanguageGemsBook;

delegate int Compare(int a, int b);

public class Delegate
{
    // 대리자(Delegate)는 콜백(Callback)을 맡아 일을 실행한다.
    public void method()
    {
        int[] array = { 3, 1, 2, 3, 7 };
        MySort.BubbleSort(array, new Compare(MySort.AscendCompare));
        
        // 익명 메소드
        MySort.BubbleSort(array, delegate(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        });
    }
}

static class MySort
{
    public static int AscendCompare(int a, int b)
    {
        if (a > b)
            return 1;
        else if (a == b)
            return 0;
        else
            return -1;
    }
    
    static int DescendCompare(int a, int b)
    {
        if (a < b)
            return 1;
        else if (a == b)
            return 0;
        else
            return -1;
    }

    public static void BubbleSort(int[] DataSet, Compare Comparer)
    {
        int i = 0;
        int j = 0;
        int temp = 0;

        for (i = 0; i < DataSet.Length - 1; i++)
        {
            for (j = 0; j < DataSet.Length - (i + 1); j++)
            {
                if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                {
                    temp = DataSet[j + 1];
                    DataSet[j + 1] = DataSet[j];
                    DataSet[j] = temp;
                }
            }
        }
    }
}