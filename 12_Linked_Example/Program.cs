public class Node
{
    public string Name { get; set; }
    public Node Next { get; set; }

    public Node(string name)
    {
        Name = name;
        Next = null;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Node name1 = new Node("Alice");
        Node name2 = new Node("Bob");
        Node name3 = new Node("Charlie");

        name1.Next = name2;
        name2.Next = name3;

        Node current = name1;

        while (current != null)
        {
            Console.WriteLine(current.Name);
            current = current.Next;
        }
    }
}
