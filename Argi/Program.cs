using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argi
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
             if (args.Length != 0)
                 foreach (string s in args)
                 {                    
                      str = s ;
                    
                }

            Console.WriteLine("write "+str);
            Console.Read();
        }

    }
}
