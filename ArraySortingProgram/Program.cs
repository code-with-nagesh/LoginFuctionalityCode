internal class Program
{
    private static void Main(string[] args)
    {
        int[] input = { 6, 8, 7, 2, 5, 1, 3, 4 };

        Array.Sort(input);

        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine(input[i]);
        }
    }

}