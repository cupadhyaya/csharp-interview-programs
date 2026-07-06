# Reverse Number

A small console application that reads an integer from the console and prints its digit-reversed value. The program demonstrates numeric manipulation using arithmetic operators and a loop.

## Program source (Program.cs)
```csharp
Console.WriteLine("Please Enter Number to Reverse!");
int number=int.Parse(Console.ReadLine());
int reverse = 0;

Console.WriteLine($"Number before reverse: {number}");

while(number>0)
{
    int remainder = number % 10;
    reverse = (reverse * 10) + remainder;
    number = number/10;
}

Console.WriteLine($"Number after reverse: {reverse}");
```

## How it works (step-by-step)
- The program prompts the user and reads a line from the console, then parses it to an int using int.Parse.
- `reverse` starts at 0. In each iteration of the while loop:
  - `remainder = number % 10` extracts the last digit.
  - `reverse = (reverse * 10) + remainder` appends that digit to the reversed number.
  - `number = number / 10` discards the last digit from the original number.
- The loop runs until `number` becomes zero, at which point `reverse` contains the original number's digits in reverse order.

## Sample runs
- Input: `1234`
  Output:
  Number before reverse: 1234
  Number after reverse: 4321

- Input: `1200`
  Output:
  Number before reverse: 1200
  Number after reverse: 21
  (Leading zeros in the reversed number are dropped because integers do not preserve leading zeros.)

## Complexity
- Time complexity: O(d) where d is the number of digits in the input (each digit processed once).
- Space complexity: O(1) — uses a constant number of scalar variables.

## Edge cases & suggestions for improvement
- Negative numbers: The current implementation treats negative numbers incorrectly because the loop condition `number > 0` will be false for negative input. To support negatives, store sign and work with the absolute value, then reapply the sign to the result.
- Input parsing: Replace int.Parse with int.TryParse to avoid exceptions on invalid input and to provide a better user experience with validation and re-prompting.
- Integer overflow: Reversing large integers can overflow the int range (e.g., reversing `1000000009` would exceed int.MaxValue). Consider using `long` (Int64) or check for overflow before multiplying/adding.
- Trailing zeros: As shown, trailing zeros in the original number are removed in the reversed integer. If you need to preserve formatting (e.g., "0012" -> "2100"), treat the input as a string.

## Improved, robust example (recommended)
```csharp
Console.Write("Enter an integer: ");
if (!long.TryParse(Console.ReadLine(), out long n))
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
    return;
}

long sign = n < 0 ? -1 : 1;
n = Math.Abs(n);
long reversed = 0;

while (n > 0)
{
    int digit = (int)(n % 10);
    // check overflow for reversed * 10 + digit
    if (reversed > (long.MaxValue - digit) / 10)
    {
        Console.WriteLine("Reversal would overflow the target type.");
        return;
    }
    reversed = (reversed * 10) + digit;
    n /= 10;
}

Console.WriteLine($"Reversed: {reversed * sign}");
```

## Variations & interview follow-ups
- Reverse a number using string manipulation: convert to string, reverse characters, then parse back (handles leading zeros explicitly if desired).
- Reverse only a portion of digits or reverse digits of every number in a list/stream.
- Check palindrome: a number is palindromic if it equals its reversed value.
- Reverse using recursion (less efficient and uses additional call stack space).

## Typical interview questions
- Q: How would you reverse an integer without converting it to a string? A: Use arithmetic extraction (mod/div) as shown. Discuss overflow handling and negative numbers.
- Q: Can you detect if reversing will overflow without actually overflowing? A: Yes — before doing reversed = reversed*10 + digit, verify reversed <= (Max - digit)/10.
- Q: How would you preserve trailing zeros from the original input? A: Treat input as a string and reverse the character sequence rather than numeric reversal.

## How to run
- .NET CLI: open a terminal in this project folder and run `dotnet run`.
- Visual Studio: set this project as StartUp Project and press F5.

---

If you want, I can update Program.cs to use the improved robust example and add unit tests for common cases (positive, negative, trailing zeros, overflow detection).