using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete tekst:");
            string inputText = Console.ReadLine();
            string[] words = inputText.ToLower().Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string,int> dic = new Dictionary<string,int>();
            foreach (var word in words)
            {
                if (dic.ContainsKey(word))
                {
                    dic[word]++;
                }
                else
                {
                    dic[word] = 1;
                }
            }
            Console.WriteLine("\nЧестота на думите:");
            foreach (var entry in dic)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
