# Remove Duplicates (in-place)

This console program demonstrates removing duplicate values from a sorted integer array in-place, leaving only unique elements at the beginning of the array. It is a common array manipulation pattern used in interview problems (similar to LeetCode's "Remove Duplicates from Sorted Array").

## Program source (Program.cs)
```csharp
int[] num = { 1, 1, 2, 2, 3, 3, 3, 3, 3, 4 };
int write = 0;

for(int read = 1; read < num.Length; read++)
{
    if (num[read] != num[write])
    {
        write++;
        num[write] = num[read];
    }
}

for(int i = 0; i < write+1; i++)
{
    Console.WriteLine(num[i]);
}
```

## What it does
- Assumes the input array `num` is sorted.
- Uses two pointers: `write` points to the last unique element found, `read` scans the array.
- When `num[read]` is different from `num[write]`, the code increments `write` and copies the unique value to `num[write]`.
- After the loop, the first `write + 1` elements of `num` are the unique values in order.

## Sample run
- Input: [1,1,2,2,3,3,3,3,3,4]
- Output printed (unique elements one per line):
  1
  2
  3
  4

## Complexity
- Time: O(n) — single pass through the array.
- Space: O(1) — in-place, constant extra space.

## Edge cases & suggestions
- Sorted requirement: This approach relies on the array being sorted. For unsorted arrays, sort first or use a HashSet to collect uniques (which uses extra space).
- Empty array: handle num.Length == 0 before accessing elements.
- Preservation of order: This method preserves the order of first occurrences.
- Return value variant: Many problem statements expect returning the count of unique elements (`write + 1`) and modifying the array in-place. Consider printing or returning that count.

## Robust example (returning new length and handling empty input)
```csharp
int RemoveDuplicates(int[] nums)
{
    if (nums == null || nums.Length == 0) return 0;
    int write = 0;
    for (int read = 1; read < nums.Length; read++)
    {
        if (nums[read] != nums[write])
        {
            write++;
            nums[write] = nums[read];
        }
    }
    return write + 1; // new length
}
```

## Interview follow-ups
- Q: How to remove duplicates from an unsorted array while preserving order? A: Use a HashSet to track seen values and copy unseen elements forward; this uses O(n) time and O(n) extra space.
- Q: Can you do it in-place for unsorted arrays without extra space? A: Not while preserving original order; you could sort first (changing order) then use the two-pointer method.
- Q: What changes if the array is very large or stored on disk? A: Use streaming techniques and external sorting or hash-based partitioning.

## How to run
- .NET CLI: open a terminal in this project folder and run `dotnet run`.
- Visual Studio: set this project as Startup Project and press F5.
