Console.WriteLine("Hello, Welcome to Prime Number Program!");
Console.WriteLine("Please Enter Number to Check Prime Or Not");

int number = int.Parse(Console.ReadLine());
bool isPrime = true;

for (int i = 2; i < number; i++)
{
    if (number % i == 0)
    {
        isPrime = false;
        break;
    }
}
if (isPrime == false)
{
    Console.WriteLine($"The given number {number} is Not Prime");
}
else
{
    Console.WriteLine($"The given number {number} is Prime");
}

