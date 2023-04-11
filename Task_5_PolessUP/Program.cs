using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] ints = { 2, 3, 1 };
        int max = ints[0];
        for (int i = 1; i < ints.Length; i++) 
        {
            if (ints[i]>max)max= ints[i];
        }
        Console.WriteLine(max);
    }
}