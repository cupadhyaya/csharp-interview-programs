public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 2, 7, 4, 11, 15 };
        int target = 11;

        int[] num = Program.TwoNum(numbers, target);

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine($"Value = {num[i]}- Index = {i}");
        }

        Console.WriteLine($"Addition of Both = {num[0]}+{num[1]} = {num[0] + num[1]}");
    }

    public static int[] TwoNum(int[] number, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < number.Length; i++)
        {
            int difference = target - number[i];

            if (map.ContainsKey(difference))
            {
                return new int[] { difference, number[i] };
            }

            map[number[i]] = i;
        }

        return new int[] { };
    }
}
