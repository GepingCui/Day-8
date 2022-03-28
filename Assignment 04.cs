/*
04 Generics

Test your Knowledge

1.Describe the problem generics address.

2.How would you create a list of strings, using the generic List class?
Use List<T>. 

3.How many generic type parameters does the Dictionary class have?
Two.

4.True/False. When a generic class has multiple type parameters, they must all match.
True.

5.What method is used to add items to a List object?
List.Add();

6.Name two methods that cause items to be removed from a List.
List.Remove(), List.RemoveAt(index);

7.How do you indicate that a class has a generic type parameter?
<T>. 

8.True/False. Generic classes can only have one generic type parameter.
False. 

9.True/False. Generic type constraints limit what can be used for the generic type.
True. 

10.True/False. Constraints let you use the methods of the thing you are constraining to.
True. 

*/




public class Stack1<T>
{
    List<T> list = new List<T>();
    public int Count()
    {
        return list.Count;
    }

    public T Pop()
    {
        T item = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return item;
    }

    public void Push(T item1)
    {
        list.Add(item1);
    }

    public void Print()
    {
        foreach (T item in list)
        {
            Console.Write(item + ",");
        }

    }
}

public class List1<T>
{
    List<T> list = new List<T>();
    public void Add(T a)
    {
        list.Add(a);
    }
    public void Remove(T a)
    {
        if (list.Contains(a))
        {
            list.Remove(a);
        }
        else
        {
            Console.WriteLine("No such Input");
        }
    }

    public bool Contains(T element)
    {
        return list.Contains(element);
    }
    public void Clear()
    {
        list.Clear();
    }
    public void InsertAt(T element, int index)
    {
        list[index] = element;
    }
    public void DeleteAt(int index)
    {
        list.RemoveAt(index);
    }
    public T Find(int index)
    {
        return list[index];
    }

}




public class Program
{
    static void Main()
    {
        Stack1<int> stack1 = new Stack1<int>();
        stack1.Push(1);
        stack1.Pop();
        stack1.Push(2);
        stack1.Push(1);
        Console.WriteLine(stack1.Count());
        stack1.Print();

        Console.WriteLine("");

        List1<string> list1 = new List1<string>();

        list1.Add("A");
        list1.Add("B");
        list1.Remove("B");
        Console.WriteLine(list1.Contains("A"));
        list1.InsertAt("C", 0);
        Console.WriteLine(list1.Find(0));
        list1.DeleteAt(0);
        list1.Clear();


    }
}