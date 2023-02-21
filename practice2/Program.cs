using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串:");
            string input = Console.ReadLine();
            int[] num = input.Split(',').Select(int.Parse).ToArray();
            var oddnum = num.Where((x) => x % 2 == 1).OrderBy((x) => x);
            Console.WriteLine("奇數:" + string.Join(",", oddnum));

            var evennum = num.Where((x) => x % 2 == 0).OrderBy((x) => x);
            Console.WriteLine("偶數:" + string.Join(",", evennum));
            Console.ReadLine();
        }
    }
}
