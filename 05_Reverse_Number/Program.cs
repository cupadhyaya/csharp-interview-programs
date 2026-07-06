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
