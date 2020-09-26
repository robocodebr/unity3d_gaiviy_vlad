using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l =  new List<string>() { "play game" };
            l.Add("Sport");
            l.Add("Prodraming");
            l.Add("Watch youtube");
            foreach (string s in l)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine(l.Count);
            l.Clear();
        }
    }
}
