using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter text to count spaces");
            string text = Console.ReadLine();
            Console.WriteLine("the num of spaces" + sp_c(text));
        }
        public static int sp_c(string text) 
        {
            
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    count++;
                }
            }
        }
    }
}
