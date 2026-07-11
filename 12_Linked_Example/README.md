# Linked List Example

This project demonstrates a simple singly linked list implemented using a Node class and manual linking. It shows how to create nodes, link them, and traverse the list to print node values.

## Program source (Program.cs)
```csharp
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
```

## What it does
- Defines a simple Node class with a string value (`Name`) and a `Next` reference.
- Creates three nodes (Alice, Bob, Charlie).
- Links them into a chain (Alice -> Bob -> Charlie).
- Traverses from the head node and prints each Name to the console.

## Sample output
Alice
Bob
Charlie

## Complexity
- Traversal (printing all nodes): O(n) time, where n is the number of nodes.
- Space: O(n) for the nodes themselves; traversal uses O(1) extra space.

## Explanation (step-by-step)
- Node constructor initializes Name and sets Next to null.
- Linking is done by assigning the Next property of a node to the subsequent node.
- The traversal uses a `current` pointer starting at the head. On each iteration, it processes the current node and advances to `current.Next` until reaching null.

## Common improvements and production considerations
- Use a generic Node<T> to store different data types instead of `string`.
- Encapsulate list operations (Add, Remove, Find, InsertAt, Reverse) in a LinkedList class rather than manipulating Node references externally.
- Use `int` counters or maintain a Count property to track list length efficiently.
- For multithreaded scenarios, provide synchronization or use concurrent collections.
- Consider using System.Collections.Generic.LinkedList<T> for production code unless you need a custom implementation for learning or specific behavior.

## Robust example: inserting and reversing (sketch)
- Insert at head: newNode.Next = head; head = newNode;
- Insert at tail: track tail pointer for O(1) append.
- Reverse iteratively:
  ```csharp
  Node prev = null;
  Node current = head;
  while (current != null)
  {
      Node next = current.Next;
      current.Next = prev;
      prev = current;
      current = next;
  }
  head = prev;
  ```

## Interview-style follow-ups
- Q: How do you reverse a singly linked list? A: Show iterative pointer reversal or recursive approach.
- Q: How to detect a cycle? A: Use Floyd's Tortoise and Hare algorithm (fast/slow pointers).
- Q: How to find the middle node in one pass? A: Use slow/fast pointers; when fast reaches end, slow is at middle.
- Q: How to delete a node given only a pointer to that node? A: Copy the next node's data into current and bypass it (cannot delete tail this way).
- Q: How to merge two sorted linked lists? A: Use a dummy head and iterate merging smaller nodes.

## Edge cases
- Empty list (head is null): traversal should do nothing.
- Single-node list: operations such as reverse should handle it gracefully.
- Cycles: traversal loops indefinitely unless you detect cycles; always be careful when processing lists that may be corrupted.

## How to run
- .NET CLI: open a terminal in this folder and run `dotnet run`.
- Visual Studio: set this project as the Startup Project and press F5.

---

If you want, I can:
- Update Program.cs to add a LinkedList wrapper with Add/Remove/Reverse methods.
- Add unit tests covering traversal, insertion, deletion, reverse, and cycle detection.
- Make the Node generic (Node<T>) and update examples accordingly.

