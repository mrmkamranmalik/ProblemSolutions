class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        for (int r = 1; r <= n; r++)
        {
            for (int c = n; c >= 1; c--)
            {
                if (c - r > 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("Enter staircase size:");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}