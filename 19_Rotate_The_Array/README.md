# Rotate The Array

A console program that rotates an integer array to the right by k steps. The current implementation performs k single-step rotations by moving the last element to the front repeatedly. This README includes the program source, explanation, sample runs, complexity analysis, and optimized approaches commonly discussed in interviews.

## Program source (Program.cs)
```csharp
static void RotateArray(int[] nums)
{
    int last = nums[nums.Length - 1];

    for(int i = nums.Length-1; i >0; i--)
    {
        nums[i] = nums[i - 1];
    }

    nums[0] = last;
}

int k = 2;

int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

for(int i = 0; i < k; i++)
{
    RotateArray(nums);
}

foreach(var item in nums)
{
    Console.WriteLine(item);
}
```

## What it does
- Defines a helper `RotateArray` that performs a single right-rotation (moves the last element to index 0 and shifts others right).
- Repeats the single-step rotation `k` times to achieve a rotation by `k` steps.
- Prints the rotated array to the console.

## Sample run
- Input array: [1,2,3,4,5,6,7], k = 2
- Output (printed one per line):
  6
  7
  1
  2
  3
  4
  5

After rotating right by 2 positions, the array becomes [6,7,1,2,3,4,5].

## Complexity (current implementation)
- Time: O(k * n) — the single-step rotation is O(n), and it is repeated k times.
- Space: O(1) — in-place rotation using constant extra space.

## Improved approaches
1) Using extra array (O(n) time, O(n) space):
```csharp
void Rotate(int[] nums, int k)
{
    int n = nums.Length;
    k %= n;
    int[] res = new int[n];
    for (int i = 0; i < n; i++)
        res[(i + k) % n] = nums[i];
    for (int i = 0; i < n; i++)
        nums[i] = res[i];
}
```

2) Reversal algorithm (O(n) time, O(1) space):
- Reverse the whole array, reverse the first k elements, then reverse the remaining n-k elements. Example:
```csharp
void Reverse(int[] arr, int start, int end)
{
    while (start < end)
    {
        int tmp = arr[start];
        arr[start] = arr[end];
        arr[end] = tmp;
        start++;
        end--;
    }
}

void Rotate(int[] nums, int k)
{
    int n = nums.Length;
    k %= n; // handle k >= n
    Reverse(nums, 0, n - 1);
    Reverse(nums, 0, k - 1);
    Reverse(nums, k, n - 1);
}
```
This method runs in O(n) time and uses O(1) extra space.

3) Cyclic replacements (O(n) time, O(1) space):
- Move elements to their correct positions using cycles determined by gcd(n, k). Careful handling required to avoid infinite loops.

## Edge cases & suggestions
- k may be greater than n: use k %= n to normalize.
- Empty array or n == 0: handle early to avoid division/modulo by zero.
- Negative k: define behavior (left rotation) or convert to equivalent positive right-rotation.
- Very large k: normalize with modulo to avoid unnecessary work.

## Interview follow-ups
- Q: How to rotate left by k positions? A: Rotate right by n - (k % n), or adapt reversal indices.
- Q: Which approach is best in interviews? A: Reversal algorithm is optimal for in-place O(n) time and O(1) space and is commonly accepted.
- Q: How to rotate in-place with minimal writes? A: Consider cyclic replacements and track visited positions.

## How to run
- .NET CLI: open a terminal in this project folder and run `dotnet run`.
- Visual Studio: set this project as the Startup Project and press F5.

---

If you want, I can:
- Replace Program.cs with an optimized implementation (reversal algorithm) and verify the build.
- Add unit tests covering k > n, k == 0, empty arrays, and typical cases.
- Generate a top-level index README that lists all projects with one-line descriptions.
