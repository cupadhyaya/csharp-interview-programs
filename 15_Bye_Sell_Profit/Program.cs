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