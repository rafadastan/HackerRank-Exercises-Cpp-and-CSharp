
class Result
{
    public static int palindromeIndex(string s)
    {
        char word = Char.MinValue;
        char nextWord = Char.MinValue;
        int position = 0;
        for (var i = 0; i < s.Length; i++)
        {
            word = s[i];
            nextWord = s[i + 1];
            if (!(word == s[i] && nextWord == s[i]))
            {
                if (word != s[i])
                {
                    position = i;
                }
                else if (nextWord != s[i])
                {
                    position = i;
                }
                else
                {
                    position = -1;
                }
            }
        }

        return position;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.palindromeIndex(s);

           // textWriter.WriteLine(result);

           Console.WriteLine(result);
        }

        Console.ReadKey();

        //textWriter.Flush();
        //textWriter.Close();
    }
}