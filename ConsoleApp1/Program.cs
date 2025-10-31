public class LinkedItem
{
    public int Value { get; set; }

    public LinkedItem Next { get; set; }

    public LinkedItem(int value)
    {
        Value = value;
    }
}
    public class LinkedList
    {
        private LinkedItem head;
        private LinkedItem tail;


    public void Add(int value)
    {
        LinkedItem newItem = new LinkedItem (value);

        if (head == null)
        {
            head = newItem; 
        } else
        {
            tail.Next = newItem;
        }
        tail = newItem;
        count++;
    }
    public void AddFirst(int value)
    {
        LinkedItem newItem = new LinkedItem (value);
        newItem.Next = head;
        head = newItem;
        if (count == 0)
        {
            tail = head;
        }
        count++;
    }
    public bool Contains(int value)
    {
        LinkedItem current = head;  
        while (current != null)
        {
            if (current.Value == value)
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }
    public int MaxValue()
    {
        int max = head.Value;
        LinkedItem current = head.Next;
        while (current != null)
        {
            if (current.Value > max)
            {
                max = current.Value;
            }
            current = current.Next;
        }
        return max;
    }
    public void PrintAll()
    {
        LinkedItem current = head;
        Console.Write("Список: ");
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
    }
class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.AddFirst(5);
        list.PrintAll();
        Console.WriteLine($"Кількість елементів: {list.Count}");
        Console.WriteLine("Чи містить 20? " + list.Contains(20));
        Console.WriteLine("Чи містить 100? " + list.Contains(100));
        Console.WriteLine("Найбільше значення: " + list.MaxValue());
    }
}