using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(101, "Ivan");
            dic.Add(103, "Viktoria");
            dic.Add(105, "Marin");
            dic.Add(107, "Iliana");
            int a =int.Parse(Console.ReadLine());
            if(dic.ContainsKey(a))
            {
                Console.WriteLine("Name:"+dic[a]);
            }
            else
            {
                Console.WriteLine("Ne suchtestvuva");
            }
        }
    }
}
