Console.WriteLine("Welcome to Factorial Number Program");
Console.Write("Please Enter the number to get the factorial : ");
int number = int.Parse(Console.ReadLine());
int factorial = 1;

for(int i = 1;i<= number; i++)
{
    factorial = factorial * i;
}

Console.WriteLine($"Factorial of given number {number} is : {factorial}");