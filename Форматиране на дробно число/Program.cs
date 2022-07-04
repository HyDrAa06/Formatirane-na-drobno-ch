using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Форматиране_на_дробно_число
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            int m;
            

            Console.Write("Въведете дробно число: ");
            n = double.Parse(Console.ReadLine());

            Console.Write("Въведете броя на знаци след запетаята: ");
            m = int.Parse(Console.ReadLine());

            n = Math.Round(n, m);
          

            Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
