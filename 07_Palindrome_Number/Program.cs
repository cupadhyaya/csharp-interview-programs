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
