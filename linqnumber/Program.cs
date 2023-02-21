using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的字串:");
            string input = Console.ReadLine();
            string[] number = input.Split(',');
            string[] reversed = number.Reverse().ToArray();
            string answer = string.Join(",", reversed);
            Console.WriteLine(answer);
            Console.ReadLine();



        }

    }
}
