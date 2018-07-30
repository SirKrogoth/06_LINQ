using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._04_LINQ_GROUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = {1, 1, 1, 2, 3, 4, 7, 9, 6, 6, 9, 7, 5, 2, 10, 11, 60, 54, 12, 4, 8};

            //GROUP - DISTINCT

            var listaFiltrada = lista.Distinct().OrderBy(a => a).Select(a => a);
            //var listaFiltrada = lista.GroupBy(a => a).Select(a => a);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
