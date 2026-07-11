public class Programs
{
    public static void Main(string[] args)
    {
        LinkedList<string> data = new LinkedList<string>();

        data.AddFirst("Alice");
        data.AddFirst("Bob");
        data.AddFirst("Sam");
        data.AddFirst("Rom");

        LinkedListNode<string> node = data.Find("Sam");

        data.AddAfter(node, "John");

        foreach(var item in data)
        {
            Console.WriteLine(item);
        }
    }
}
