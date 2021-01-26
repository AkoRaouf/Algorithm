using System.IO;
using System;

namespace OtherExamples
{
    public class Solution
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            int steps = 0;
            var index = 0;
            while (index < c.Length - 1)
            {
                if (index + 2 <= c.Length - 1 && c[index + 2] == 0)
                    index += 2;
                else
                    index += 1;

                if (index < c.Length)
                    steps++;
            }
            return steps;
        }

        int recFunc(int[] c, int index, int steps)
        {
            if (index == c.Length)
                return 1;

            return steps + recFunc(c, c[index + 2] == 0 ? index + 2 : index + 1, steps++);    
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
