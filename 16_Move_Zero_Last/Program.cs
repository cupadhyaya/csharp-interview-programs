int[] num = { 1, 0, 2, 0, 3, 0 };
int write = 0;

for(int read = 0; read < num.Length; read++)
{
    if(num[read] != 0)
    {
        num[write] = num[read];
        write++;
    }
}

// Fill the remaining positions with zero
while (write < num.Length)
{
    num[write] = 0;
    write++;
}

foreach (int number in num)
{
    Console.Write(number + " ");
}

