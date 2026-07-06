Console.WriteLine("Please Enter Two Numbers a and b");
Console.Write("Please Enter a : ");
int a=int.Parse(Console.ReadLine());
Console.Write("Please Enter b : ");
int b=int.Parse(Console.ReadLine());

Console.WriteLine($"Number before swap a={a} and b={b}");

try
{
    int temp = b;
    b = a;
    a = temp;

    Console.WriteLine($"Number after swap a={a} and b={b}");
}
catch
{
    Console.WriteLine("Enter Numbers Only......");
}
