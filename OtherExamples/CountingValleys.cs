using System.IO;
using System;

class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        var count = 0;
        var sumUp = 0;
        foreach (var item in path.ToCharArray())
        {
            if (item == ('U'))
            {
                if (++sumUp == 0)
                    count++;
            }
            else
                --sumUp;
        }
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(12, "DDUUDDUDUUUD");

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
