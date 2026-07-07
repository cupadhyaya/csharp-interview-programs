Console.WriteLine("Hello, Welcome to Fibonacci Series Program!");
Console.Write("Please enter number to get Series : ");
int number = int.Parse(Console.ReadLine());
int firstNumber = 0, secondNumber = 1, nextNumber;
Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);

for (int i=1;i<number; i++)
{
    nextNumber = firstNumber + secondNumber;
    Console.WriteLine(nextNumber);
    firstNumber = secondNumber;
    secondNumber = nextNumber;
}
