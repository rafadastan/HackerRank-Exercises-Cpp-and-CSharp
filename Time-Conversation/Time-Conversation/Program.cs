using System;
using System.IO;

namespace Time_Conversation
{
    class Result
    {

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string timeConversion(string s)
        {
            var newHorario = DateTime.Parse(s);

            return newHorario.ToString("HH:mm:ss");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();

            Console.ReadKey();
        }
    }
}
