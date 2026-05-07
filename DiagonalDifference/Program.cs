using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int DiagonalDifference(List<List<int>> arr)
    {
        List<int> ltrDiagonal = new List<int>();
        List<int> rtlDiagonal = new List<int>();

        for (int r = 0; r < arr.Count; r++)
        {
            var row = arr[r].ToList();
            ltrDiagonal.Add(row[r]);
            rtlDiagonal.Add(row[(row.Count - 1) - r]);
        }

        return Math.Abs(ltrDiagonal.Sum() - rtlDiagonal.Sum());
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("Enter square matrix size:");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();
        Console.WriteLine("Enter matrix values. (please use space b/w values");
        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        int result = Result.DiagonalDifference(arr);
        Console.WriteLine("Diagonal difference = {0}",result);
    }
}
