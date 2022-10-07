using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.001f;
            double suma = 0f;
            for (int i = 0; i < 1000000; i++)
            {
                suma += eps;
            }
            Console.WriteLine(suma);
            Console.Write("tot nui bine \n");
        }
    }
}
