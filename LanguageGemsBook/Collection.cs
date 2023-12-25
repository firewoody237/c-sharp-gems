using System.Collections;

namespace LanguageGemsBook;

public class Collection
{
    public void method()
    {                                               
        // ArrayList
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Insert(1, 2);
        arrayList.RemoveAt(1);
        
        // Queue
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Dequeue();
        
        // Stack
        Stack stack = new Stack();
        stack.Push(1);
        stack.Pop();
        
        // Hashtable
        Hashtable hashTable = new Hashtable();
        hashTable["One"] = "1";
        hashTable["Two"] = "2";
        
        // foreach
        // IEnumerable을 구현 해야 함
        foreach (object temp in arrayList)
        {
            Console.WriteLine(temp.ToString());
        }
        
        //일반화 컬렉션-----------------------------
        List<int> list = new List<int>();

        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic["One"] = "1";
    }
}

class MyList
{
    private int[] array;

    public MyList()
    {
        array = new int[3];
    }

    public int this[int index] // Indexer
    {
        get
        {
            return array[index];
        }

        set
        {
            if (index >= array.Length)
            {
                System.Array.Resize<int>(ref array, index + 1);
            }

            array[index] = value;
        }
    }
}