using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double n,i,z=0;
            Console.Write("Введите n:");
            n = Convert.ToDouble(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                Console.WriteLine($"{z}+{i}=" + (z + i));
                z = z + i;
            }
            Console.ReadKey();
        }
    }
}
