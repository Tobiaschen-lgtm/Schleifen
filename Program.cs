using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen
{
    class Program
    {
        static void Main(string[] args)

        {
            for(int i=10; i>=0; i=i-2)
            {
                Console.WriteLine("Durchlauf {0}", i);
            }


            int a = 1;
                while (a < 32)
            {
                a = a * 2;
                Console.WriteLine(a);
            }
            int b = 1;
            do
            {
                b = b * 2;
                Console.WriteLine(b);
            }
            while (b < 32);
        }
    }
}
