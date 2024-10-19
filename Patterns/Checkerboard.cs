//8)

//1 0 1 0 1
//0 1 0 1 0
//1 0 1 0 1
//0 1 0 1 0
//1 0 1 0 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Checkerboard
    {
        //static void Main(string[] args)
        //{
        //    int n = 5;
        //    for(int i=0; i < n; i++)
        //    {
        //        for(int j=0; j < n; j++)
        //        {
        //            if((i + j) % 2 ==0)
        //            {
        //                   Console.Write("1 ");
        //            }
        //            else
        //            {
        //                Console.Write("0 ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}


        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("0 1 0 1");
                }
                else
                {
                    Console.WriteLine("1 0 1 0");
                }
                Console.WriteLine();
            }
        }
    }
}
