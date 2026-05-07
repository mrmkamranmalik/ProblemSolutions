using System;

class Result
{
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int n = arr.Count;
        int positives = arr.Count(x => x > 0);
        int negatives = arr.Count(x => x < 0);
        int zeros = arr.Count(x => x == 0);
        
        // Fixed-point:
        //.ToString("F6") ensure 6 decimal places by padding 0 if necessary.

        var ratio = ((decimal)positives / n).ToString("F6");
        Console.WriteLine(ratio);

        ratio = ((decimal)negatives / n).ToString("F6");
        Console.WriteLine(ratio);

        ratio = ((decimal)zeros / n).ToString("F6");
        Console.WriteLine(ratio);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array size:");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Console.Write("Enter space-saperated integers:");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

