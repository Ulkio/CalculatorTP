using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                System.Console.WriteLine(arg);
            }
        }
    }
}
