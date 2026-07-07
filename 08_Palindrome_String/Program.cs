Console.WriteLine("Hello, World! Program to Check Palindrome String");
Console.WriteLine("Please Enter String to check palindrome");
string value = Console.ReadLine();

string reverse = string.Empty;

for (int i = value.Length - 1; i >= 0; i--)
{
    reverse += value[i];
}

if (value == reverse)
{
    Console.WriteLine($"Entered string {value} is palindrome.");
}
else
{
    Console.WriteLine($"Entered string {value} is not palindrome.");
}
