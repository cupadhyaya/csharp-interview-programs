try
{
    Console.WriteLine("Please Enter Number to Find Wether Odd or Even...");
    int number = int.Parse(Console.ReadLine());
    if (number > 0)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("The Given Number is Even");
        }
        else
        {
            Console.WriteLine("The Given Number is Odd");
        }
    }
    else
    {
        Console.WriteLine("Please Enter a Valid Number");
    }
}
catch
{
    Console.WriteLine("Enter only numbers...");
}

