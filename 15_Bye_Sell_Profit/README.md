# Buy / Sell Profit (Single Transaction)

A small console program that demonstrates a simple approach for finding a buy day and computing profit from a hard-coded price array. The current implementation provided in Program.cs tracks a minimum observed price and a maximum observed price; improvements are recommended for correct maximum-profit computation.

## Program source (Program.cs)
```csharp
int[] num = { 1,7, 4, 5, 4, 6 };
int minPrice = num[0], maxPrice = 0, day = 0;

for (int i = 1; i < num.Length; i++)
{
    if (minPrice > num[i])
    {
        day = i;
        minPrice = num[i];
    }
    else
    {
        if (maxPrice < num[i]) { maxPrice = num[i]; }
    }
}
Console.WriteLine($"customer bought the product at day {day+1} and price Rupees: {minPrice}");
Console.WriteLine($"customer sold the product with profit Rupees : {maxPrice - minPrice}");
```

## What it does
- Uses a hard-coded array of daily prices `num`.
- Tracks the smallest price seen so far (`minPrice`) and the index (`day`) where that minimum occurred.
- Also tracks a `maxPrice` value seen when the current price was not smaller than the running minimum.
- Prints the (1-based) buy day and a profit computed as `maxPrice - minPrice`.

## Sample output (for the hard-coded input)
Input array: [1, 7, 4, 5, 4, 6]
Output (example):
```
customer bought the product at day 1 and price Rupees: 1
customer sold the product with profit Rupees : 6
```

## Complexity
- Time: O(n) — single pass over the price array.
- Space: O(1).

## Issues & recommended fix
- The current approach may not always produce the maximum achievable profit because `maxPrice` can reflect values seen before the best `minPrice` is found. The standard one-pass solution computes the maximum profit by tracking the minimum price and updating the maximum profit at each step:

```csharp
int[] prices = {1,7,4,5,4,6};
int minPrice = int.MaxValue;
int maxProfit = 0;
int buyDay = -1, sellDay = -1;

for (int i = 0; i < prices.Length; i++)
{
    if (prices[i] < minPrice)
    {
        minPrice = prices[i];
        buyDay = i;
    }

    int profit = prices[i] - minPrice;
    if (profit > maxProfit)
    {
        maxProfit = profit;
        sellDay = i;
    }
}

Console.WriteLine($"Buy at day {buyDay+1} price {prices[buyDay]}");
Console.WriteLine($"Sell at day {sellDay+1} price {prices[sellDay]}");
Console.WriteLine($"Max profit: {maxProfit}");
```

- This revised method guarantees the best single buy/sell pair where the buy day is before the sell day.

## Variations & interview follow-ups
- Multiple transactions allowed: sum positive differences between consecutive days or use dynamic programming for k transactions.
- Allow short-selling or transaction fees: adapt algorithm to include constraints.

## How to run
- .NET CLI: open a terminal in this project folder and run `dotnet run`.
- Visual Studio: set this project as Startup Project and press F5.
