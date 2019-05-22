using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagulho_do_BizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, buzz, bizz;
            num = int.Parse(Console.ReadLine());
            for(int j = 1; j <= num; j++)
            {
                bizz = j % 3;
                buzz = j % 5;
                if (bizz == 0 && buzz == 0)
                {
                    Console.WriteLine("BizzBuzz");
                }
               else if (buzz == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(bizz == 0)
                {
                    Console.WriteLine("Bizz");
                }
                else
                {
                    Console.WriteLine(j);
                }
            }
            Console.ReadKey();
        }
    }
}
