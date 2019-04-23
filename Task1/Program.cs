using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstBigLetter();
            Console.ReadKey();
        }

        public static void FirstBigLetter()
        {
            Console.WriteLine("Enter the text");
            string text = Console.ReadLine();
            string resultText = String.Empty;

            String[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Remove(0, 1);
                resultText += words[i] + " ";
            }
            Console.WriteLine(resultText);
        }
    }
}
