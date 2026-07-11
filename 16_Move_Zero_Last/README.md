# Move Zeroes to End

A console program that moves all zeros in an integer array to the end while preserving the relative order of non-zero elements. The implementation performs this in-place using a write pointer.

## Program source (Program.cs)
```csharp
int[] num = { 1, 0, 2, 0, 3, 0 };
int write = 0;

for(int read = 0; read < num.Length; read++)
{
    if(num[read] != 0)
    {
        num[write] = num[read];
        write++;
    }
}

// Fill the remaining positions with zero
while (write < num.Length)
{
    num[write] = 0;
    write++;
}

foreach (int number in num)
{
    Console.Write(number + " ");
}
```

## What it does
- Iterates the array with a `read` pointer and copies every non-zero element to the `write` position.
- After scanning all elements, fills the remainder of the array with zeros.
- This preserves the order of non-zero elements and performs the operation in-place.

## Sample run
Input: [1, 0, 2, 0, 3, 0]
Output printed to console: `1 2 3 0 0 0 `

## Complexity
- Time: O(n) — single pass to move non-zero elements plus a second pass to fill zeros.
- Space: O(1) — in-place, using constant extra space.

## Alternatives & variations
- Stable in-place: the current algorithm preserves relative order of non-zero items.
- Two-pass vs single-pass: this is a two-pass approach (one to copy non-zeros, second to fill zeros). It is optimal for clarity and safety.
- Using stable partition algorithms or LINQ (less efficient due to allocations): `var result = arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();`

## Interview questions
- Q: Why does this preserve order? A: Because we copy non-zero elements in their original scanning order to the write pointer.
- Q: Can you do it with minimal writes? A: You can reduce writes by swapping only when needed, but swapping may change relative order.
- Q: How to do it in a single-pass without a second fill loop? A: You can swap zeros with subsequent non-zero elements as you find them, but still need to ensure relative order (which may complicate the approach).

## How to run
- .NET CLI: open a terminal in this project folder and run `dotnet run`.
- Visual Studio: set this project as Startup Project and press F5.
