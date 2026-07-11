int[] num = { 1, 1, 2, 2, 3, 3, 3, 3, 3, 4 };
int write = 0;

for(int read = 1; read < num.Length; read++)
{
    if (num[read] != num[write])
    {
        write++;
        num[write] = num[read];
    }
}

for(int i = 0; i < write+1; i++)
{
    Console.WriteLine(num[i]);
}
