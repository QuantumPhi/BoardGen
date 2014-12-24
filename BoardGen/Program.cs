using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGen
{
    class Program
    {
        static readonly Random random = new Random();

        static void Main(string[] args)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string board = "";

            for(int i = 0; i < 16; i++)
            {
                board += letters[random.Next(letters.Length)];
            }

            Console.WriteLine(board);
        }
    }
}
