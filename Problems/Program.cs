using System;

namespace Problems
{
    public class Program
    {
       public string Prefix(string h)
        {
            string[] arr = h.Split(' ');
            int s = 0;
            if (h != "")
            {
                for (int d = 0; d < arr.Length; d++)
                {
                    s += arr[d].Length;
                }
                h = $"{s},{arr.Length}:" + h;
            }
            else h = "0,0:";
            return h;
        }
        static void Main(string[] args)
        {
          //  Console.WriteLine(Prefix(""));
        }
    }
}
