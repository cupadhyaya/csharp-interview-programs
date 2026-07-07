# Palindrome String

A console program that checks whether a string is a palindrome (reads the same forwards and backwards). The program preserves exact characters and case in the current implementation.

## Program source (Program.cs)
```csharp
Console.WriteLine("Hello, World! Program to Check Palindrome String");
Console.WriteLine("Please Enter String to check palindrome");
string value = Console.ReadLine();

string reverse = string.Empty;

for (int i = value.Length - 1; i >= 0; i--)
{
    reverse += value[i];
}

if (value == reverse)
{
    Console.WriteLine($"Entered string {value} is palindrome.");
}
else
{
    Console.WriteLine($"Entered string {value} is not palindrome.");
}
```

## How it works
- Reads the input string.
- Builds a reversed string by iterating characters from end to start.
- Compares the original and reversed strings for equality.

## Sample runs
- Input: `madam`
  Output: Entered string madam is palindrome.

- Input: `Racecar`
  Output: Entered string Racecar is not palindrome. (case-sensitive)

## Complexity
- Time: O(n^2) with current implementation due to repeated string concatenation; O(n) if using StringBuilder or char[].
- Space: O(n).

## Improvements
- Use StringBuilder or char[] with Array.Reverse for O(n) performance.
- Normalize input (to lower case and remove non-alphanumeric characters) to check palindromes ignoring case and punctuation.
- Handle null input defensively.

## Interview follow-ups
- Q: How would you check palindrome ignoring case and punctuation? A: Preprocess string with a filter and compare, or use two-pointer technique skipping non-alphanumeric characters.
- Q: How to implement in-place reversal? A: Convert to char[] and swap in-place.

## How to run
- .NET CLI: run `dotnet run` in this project folder.
- Visual Studio: set project as Startup Project and press F5.
