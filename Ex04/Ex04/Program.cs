using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tossing a coin...");
            Random r = new System.Random();
            int head = 0;
            int tail = 0;
            for(int i = 0; i < 3; i++)
            {
                if(r.Next() % 2 == 0)
                {
                    Console.WriteLine("Round {0}: Heads", i + 1);
                    head++;
                }
                else
                {
                    Console.WriteLine("Round {0}: Tails", i + 1);
                    tail++;
                }
            }
            Console.WriteLine("Heads: {0}, Tails: {1}", head, tail);
        }
    }
}
