using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02_LINQ_OBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>();

            lista.Add(new Usuario() { nome = "João",   email = "joao@gmail.com"});
            lista.Add(new Usuario() { nome = "Pedro",  email = "pedrinho69@gmail.com" });
            lista.Add(new Usuario() { nome = "Maria",  email = "maria@ig.com" });
            lista.Add(new Usuario() { nome = "Samuel", email = "samuca@hotmail.com" });
            lista.Add(new Usuario() { nome = "Luan",   email = "luan@gmail.com" });

            var listaFiltrada = lista.Where(a => a.email.Contains("@ig.com")).Select(a => a);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item.nome + " - " + item.email);
            }

            Console.ReadKey();
        }
    }
}
