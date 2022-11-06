using System;
using System.IO;
using System.Linq;

class Result
{

    /*
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    //public static int superDigit(string n, int k)
    //{
    //    if (n.Length == 1)
    //    {
    //        return int.Parse(n);
    //    }
    //    else
    //    {
    //        long sum = 0;
    //        for (int i = 0; i < n.Length; i++)
    //        {
    //            sum += int.Parse(n[i].ToString());
    //        }
    //        sum *= k;
    //        return superDigit(sum.ToString(), 1);
    //    }
    //}


    public static int superDigit(string n, int k)
    {
        while (true)
        {
            if (n.Length == 1)
            {
                return int.Parse(n);
            }

            long sum = n.Aggregate(0, (current, t) => current + Convert.ToInt16(Convert.ToString(t)));

            sum *= k;
            n = sum.ToString();
            k = 1;
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = n.Length;

        int result = Result.superDigit(n, k);

        Console.WriteLine(result);

        Console.ReadKey();
    }
}