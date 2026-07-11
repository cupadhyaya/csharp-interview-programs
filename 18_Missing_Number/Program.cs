//int[] num = { 0,1, 2, 3,4, 5 ,6,7,8,9,10,11,12,13,15};

//int tot = num.Length * (num.Length + 1) / 2;

//int fin=num.Sum();

//int missing = tot - fin;

//Console.WriteLine(missing);


//if missing multiple numbers
int[] num1 = { 1, 2, 4, 5, 6, 7, 8 };

int max = num1.Max();

for(int i = 0; i < max; i++)
{
    if(!num1.Contains(i))
    {
        Console.WriteLine(i);
    }
}