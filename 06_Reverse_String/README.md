# Reverse String

This console application reads a string from the user and prints its characters in reverse order. It's a simple demonstration of loops, indexing, and string manipulation in C# and is a common beginner/interview exercise.

## Program source (Program.cs)
```csharp
Console.WriteLine("Please Enter String to Reverse!");
string value = Console.ReadLine();
string reverse = string.Empty;

Console.WriteLine($"String before reverse: {value}");

for(int i=value.Length-1;i>=0; i--)
{
    reverse += value[i];
}

Console.WriteLine($"String after reverse: {reverse}");
```

## How it works (step-by-step)
- The program reads input via Console.ReadLine() into `value`.
- It initializes `reverse` as an empty string and iterates from the last character index down to 0.
- In each iteration it appends the current character to `reverse`.
- Finally it prints the reversed string.

## Sample runs
- Input: `hello`
  Output:
  String before reverse: hello
  String after reverse: olleh

- Input: `A man, a plan, a canal`  (spaces and punctuation are preserved)
  Output:
  String before reverse: A man, a plan, a canal
  String after reverse: lanac a ,nalp a ,nam A

## Complexity
- Time complexity: O(n^2) for the current implementation because string concatenation in a loop creates a new string on each iteration.
- Space complexity: O(n) for the resulting reversed string.

## Improvements and robust implementations
- Use StringBuilder or operate on a char[] to achieve O(n) time.

Example using char array (recommended):
```csharp
string s = Console.ReadLine() ?? string.Empty;
char[] arr = s.ToCharArray();
Array.Reverse(arr);
string reversed = new string(arr);
Console.WriteLine(reversed);
```

Example using StringBuilder:
```csharp
var sb = new StringBuilder(s.Length);
for (int i = s.Length - 1; i >= 0; i--)
    sb.Append(s[i]);
Console.WriteLine(sb.ToString());
```

Example using LINQ (concise but allocates an array):
```csharp
string reversed = new string(s.Reverse().ToArray());
```

## Edge cases & Unicode considerations
- Null input: handle null returned from Console.ReadLine() when necessary.
- Unicode and grapheme clusters: reversing by char may split surrogate pairs or combined grapheme clusters (e.g., emojis, accented letters). For user-facing text with complex scripts, use System.Globalization.StringInfo to operate on text elements (grapheme clusters) rather than char units.

## Variations & interview follow-ups
- Reverse words in a sentence while preserving word order or reversing the order of words.
- Reverse in-place a mutable char array: swap characters from ends toward the center.
- Detect palindromes (ignoring punctuation/case) using two-pointer technique.
- Reverse only a portion of the string (given indices).

## Typical interview questions
- Q: Why is the given implementation O(n^2)? A: Because strings are immutable; concatenation inside a loop creates a new string each time.
- Q: How would you reverse the string in-place? A: Convert to char[], then swap arr[i] and arr[n-1-i] up to the midpoint.
- Q: How do you handle Unicode properly? A: Use StringInfo and work with TextElementEnumerator or grapheme clusters when the exact visual characters must be preserved.

## How to run
- .NET CLI: open a terminal in this project folder and run `dotnet run`.
- Visual Studio: set this project as Startup Project and press F5.

---

If you want, I can update Program.cs to use the recommended char[] approach or add unit tests covering ASCII and Unicode examples.