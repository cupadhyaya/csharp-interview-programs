# LinkedList Example (System.Collections.Generic.LinkedList<T>)

This project demonstrates using the built-in LinkedList<T> from System.Collections.Generic. It shows how to add nodes at the front, find a node, insert after a node, and iterate the list.

## Program source (Program.cs)
```csharp
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
```

## What it does
- Creates a LinkedList<string> and adds items using AddFirst (which inserts at the head).
- Finds a node containing the value "Sam" using Find.
- Inserts "John" after the found node using AddAfter.
- Iterates the list and prints each item.

## Sample output
Depending on AddFirst insertion order, output will be (head first):

Rom
Sam
John
Bob
Alice

Explanation: Items were added to the head: AddFirst("Alice") then AddFirst("Bob") results in Bob -> Alice, etc. After finding "Sam" and adding "John" after it, the traversal prints the final sequence.

## Complexity
- AddFirst: O(1)
- Find: O(n) — linear search to locate a node
- AddAfter (given node): O(1)
- Iteration: O(n)

## Notes & improvements
- This example uses the framework-provided LinkedList<T>. For learning purposes, implementing your own singly/doubly linked list can help understand pointer manipulation.
- When building a custom linked list, provide encapsulated methods for AddFirst, AddLast, AddAfter, Remove, Find, Reverse, and maintain a Count for O(1) size retrieval.
- Consider null checks: Find returns null if the value is not present; ensure AddAfter is not called with a null node.

## Interview-style follow-ups
- Q: How to insert at tail efficiently? A: Maintain a tail reference and update it on inserts for O(1) append.
- Q: How to reverse the linked list in-place? A: Use iterative pointer reversal tracking previous/current/next.
- Q: How to detect a cycle? A: Use Floyd's cycle-finding algorithm (slow/fast pointers).

## How to run
- .NET CLI: run `dotnet run` in this project folder.
- Visual Studio: set project as Startup Project and press F5.
