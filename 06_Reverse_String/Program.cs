Console.WriteLine("Please Enter String to Reverse!");
string value = Console.ReadLine();
string reverse = string.Empty;

Console.WriteLine($"String before reverse: {value}");

for(int i=value.Length-1;i>=0; i--)
{
    reverse += value[i];
}

Console.WriteLine($"String after reverse: {reverse}");