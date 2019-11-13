using System;

namespace Delegates
{
    public class Program
    {
        private static void Main(string[] args)
        {
            StcConcat sc = new StcConcat("hollow words written here");

            Action<string> gAs = ToUpper;
            gAs += ToLower;
            gAs += sc.ConcatAndPrint;

            gAs("This is a text but,");

        }
        public static void ToUpper(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        public static void ToLower(string text)
        {
            Console.WriteLine(text.ToLower());
        }
    }
}
