using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = {3, 4, 8, 20, 15, 80, 90, 70, 60, 50};

            var listaFiltrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
