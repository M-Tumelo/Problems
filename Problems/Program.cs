using System;

namespace Problems
{
    public class Program
    {
       static string Prefix(string h)
        {
            int s = h.Length;
            string[] delimters = new string[] { " " };
            string[] arr = h.Split(delimters, StringSplitOptions.RemoveEmptyEntries);

            if (h != "")
            {
                h = $"{s}.{arr.Length}: " + h;
            }
            else h = "0,0:";
            return h;
        }
        static void Main(string[] args)
        {
             Console.WriteLine(Prefix("what ... did you say??"));
        }
    }
}
