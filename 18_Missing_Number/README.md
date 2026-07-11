# Missing Number(s)

This console program demonstrates simple techniques to find missing numbers from a sequence. The repository contains two variants: a commented example that finds a single missing number using the sum formula, and an active example that identifies all missing numbers in a (possibly incomplete) range using simple membership checks.

## Program source (Program.cs)
```csharp
//int[] num = { 0,1, 2, 3,4, 5 ,6,7,8,9,10,11,12,13,15};

//int tot = num.Length * (num.Length + 1) / 2;

//int fin=num.Sum();

//int missing = tot - fin;

//Console.WriteLine(missing);


//if missing multiple numbers
int[] num1 = { 1, 2, 4, 5, 6, 7, 8 };

int max = num1.Max();

for(int i = 0; i < max; i++)
{
    if(!num1.Contains(i))
    {
        Console.WriteLine(i);
    }
}
```

## What it does
- Variant 1 (single missing number - commented out): uses arithmetic sum formula for the first n natural numbers. With an array containing numbers from 0..n with one missing value, compute expected total and subtract the actual sum to get the missing number.
- Variant 2 (active): finds all missing integers in the range [0, max-1] where `max` is the maximum value present in the array. It checks membership for each i in that range and prints values not contained in the array.

## Sample runs
- Single missing number example (uncommented and adjusted):
  Input array: [0,1,2,3,4,5,6,7,8,9,10,11,12,13,15]
  Computation: expected sum for 0..15 = 15*16/2 = 120, actual sum = 105, missing = 120 - 105 = 15.

- Multiple missing numbers example (current code):
  Input array: [1,2,4,5,6,7,8]
  Output printed:
  0
  3

  (prints numbers between 0 and max-1 that are not present in the array)

## Complexity
- Single-missing (sum formula): O(n) time to compute sum, O(1) extra space.
- Multiple-missing naive check (current implementation): O(n * m) if Contains is O(n) — resulting in O(n^2) worst-case time. Space is O(1) beyond the input array.

## Improvements
- Use a HashSet<int> of the array elements to make membership checks O(1), reducing overall time to O(n):
```csharp
var set = new HashSet<int>(num1);
for (int i = 0; i < max; i++)
{
    if (!set.Contains(i)) Console.WriteLine(i);
}
```
- To find a single missing number robustly when numbers are large, consider using XOR technique to avoid overflow: XOR all expected values and XOR with array values; the result is the missing number.
- If the input range isn't guaranteed to start at 0 or 1, compute min and max and iterate that range.

## Edge cases & suggestions
- Duplicates: current membership logic ignores duplicates; HashSet approach still handles duplicates correctly for membership tests.
- Unsorted inputs: methods shown work regardless of order; sorting is not required.
- Large ranges: be careful when iterating from min to max if the range is huge — consider streaming or external algorithms.

## Interview follow-ups
- Q: How do you find one missing number in O(n) time and O(1) space? A: Use sum formula (beware overflow) or XOR technique to avoid overflow.
- Q: How to find multiple missing numbers efficiently? A: Use a HashSet for membership checks or sort and scan; complexity O(n) time and O(n) space for HashSet.
- Q: How to handle multiple missing numbers when the expected range is unknown? A: Compute min/max from the data and check the inclusive range, or rely on external metadata about expected range.

## How to run
- .NET CLI: open a terminal in this project folder and run `dotnet run`.
- Visual Studio: set this project as the Startup Project and press F5.
