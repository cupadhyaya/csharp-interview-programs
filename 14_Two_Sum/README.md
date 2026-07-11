# Two Sum

A console program that finds two numbers in an array that add up to a specified target value. The implementation uses a dictionary (hash map) to achieve O(n) time complexity.

## Program source (Program.cs)
```csharp
public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 2, 7, 4, 11, 15 };
        int target = 11;

        int[] num = Program.TwoNum(numbers, target);

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine($"Value = {num[i]}- Index = {i}");
        }

        Console.WriteLine($"Addition of Both = {num[0]}+{num[1]} = {num[0] + num[1]}");
    }

    public static int[] TwoNum(int[] number, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < number.Length; i++)
        {
            int difference = target - number[i];

            if (map.ContainsKey(difference))
            {
                return new int[] { difference, number[i] };
            }

            map[number[i]] = i;
        }

        return new int[] { };
    }
}
```

## How it works
- Iterates the array once. For each value `number[i]`, computes `difference = target - number[i]` and checks whether `difference` was previously seen (in the map).
- If previously seen, returns the pair (difference, number[i]) which sum to the target.
- Otherwise stores the current number and its index in the map for future matches.

## Sample run (using hardcoded array)
- Input array: [2, 7, 4, 11, 15], target = 11
- Output (one valid pair):
  Value = 4- Index = 0
  Value = 7- Index = 1
  Addition of Both = 4+7 = 11

Note: The current implementation returns the two numbers (values) rather than their indices. To return indices change the returned array accordingly.

## Complexity
- Time: O(n) — single pass through the array.
- Space: O(n) — storing seen values in the dictionary.

## Edge cases & suggestions
- Duplicate values: the map stores the last index for a value; ensure logic handles duplicates as required.
- Empty/no solution: currently returns an empty array; consider returning null or throwing an exception when no pair exists.
- Return indices instead of values: common problem variant requires returning indices; modify return statements to return indices stored in the dictionary.

## Interview follow-ups
- Q: How to return indices instead of values? A: When match found, return new int[] { map[difference], i }.
- Q: How to handle multiple pairs? A: Collect pairs in a list instead of returning immediately.
- Q: Can you do it without additional space? A: Sort-and-two-pointer approach yields O(n log n) time plus O(1) extra space, but indices mapping becomes harder.

## How to run
- .NET CLI: run `dotnet run` in this project folder.
- Visual Studio: set project as Startup Project and press F5.
