# Palindrome Number

A console program that checks whether an integer is a palindrome. A number is a palindrome if it reads the same backward as forward (e.g., 121, 1331).

## Program source (Program.cs)
```csharp
Console.WriteLine("Hello, World! Program to Check Palindrome Number");
Console.WriteLine("Please Enter Number to check palindrome");

int currentValue = int.Parse(Console.ReadLine());
int reverse = 0;
int value = currentValue;

while (value > 0)
{
    int remainder = value % 10;
    reverse = reverse * 10 + remainder;
    value = value / 10;
}

if (currentValue == reverse)
{
    Console.WriteLine($"Entered number {currentValue} is palindrome.");
}
else
{
    Console.WriteLine($"Entered number {currentValue} is not palindrome.");
}
```

## How it works
- Reads an integer from input (`currentValue`).
- Uses the numeric reversal technique (extract digits with `% 10` and build the reversed integer) to compute `reverse`.
- Compares the original `currentValue` with `reverse` to determine palindromicity.

## Sample runs
- Input: `121`
  Output: Entered number 121 is palindrome.

- Input: `123`
  Output: Entered number 123 is not palindrome.

## Complexity
- Time: O(d) where d is the number of digits.
- Space: O(1).

## Edge cases & suggestions
- Negative numbers: current implementation treats negative numbers as non-palindromic because of the minus sign. If negatives should be supported, decide whether to ignore the sign or treat them as non-palindromes.
- Input parsing: switch to int.TryParse for robust input handling.
- Overflow: reversing large integers may overflow the type; use long and overflow checks if necessary.

## Variations & interview follow-ups
- Reverse half the number only to avoid overflow: compare first half and reversed second half.
- Check palindrome for strings, ignoring punctuation/case.

## How to run
- .NET CLI: run `dotnet run` in this project folder.
- Visual Studio: set project as Startup Project and press F5.
