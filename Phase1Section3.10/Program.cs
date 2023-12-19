using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._10
{
    internal class Program
    {
        public static void WithText()
        {
            string txt = "Helo From Working with text";
            Console.WriteLine("Original string=" + txt);
            Console.WriteLine("Clone of a string =" + txt.Clone());
            Console.WriteLine("Compare two strings =" + txt.CompareTo("Helo From Working with text"));
            Console.WriteLine("Characters in a string r =" + txt.Contains("r"));
            Console.WriteLine("String ending with text =" + txt.EndsWith("text"));
            Console.WriteLine("All lowercase =" + txt.ToLower());
            Console.WriteLine("All uppercase =" + txt.ToUpper());
            Console.WriteLine("Insert string within a string =" + txt.Insert(4, " Insert New String"));
            Console.WriteLine("\nSplitting string into words:");
            string[] words = txt.Split(' ');
            foreach (var p in words)
            {
                Console.WriteLine(p);
            }

            StringBuilder NewTxt = new StringBuilder("");
            for (int i = 0; i < words.Length; i++)
            {
                NewTxt.Append(words[i].ToString() + " ");
            }
            Console.WriteLine("Append text");
            Console.WriteLine(NewTxt.ToString());

        }
        static void Main(string[] args)
        {
            WithText(); 
            Console.ReadLine();
        }
    }
}
