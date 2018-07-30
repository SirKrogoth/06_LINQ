using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06._03_LINQ_JOIN._01_Autores;
using _06._03_LINQ_JOIN._02_Livros;

namespace _06._03_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<_01_Autores.Autor> listaAutores = new List<Autor>();

            listaAutores.Add(new _01_Autores.Autor() { id = 1, nome = "João Rafael" });
            listaAutores.Add(new _01_Autores.Autor() { id = 2, nome = "Maria Josefa" });
            listaAutores.Add(new _01_Autores.Autor() { id = 3, nome = "Augusto Cury" });

            List<_02_Livros.Livro> listaLivros = new List<Livro>();

            listaLivros.Add(new _02_Livros.Livro() { id = 1, idAutor = 2, titulo = "Amor amado" });
            listaLivros.Add(new _02_Livros.Livro() { id = 2, idAutor = 2, titulo = "Bem amado" });
            listaLivros.Add(new _02_Livros.Livro() { id = 3, idAutor = 1, titulo = "João e o pé de feijão" });
            listaLivros.Add(new _02_Livros.Livro() { id = 4, idAutor = 1, titulo = "Thor Ragnarock" });
            listaLivros.Add(new _02_Livros.Livro() { id = 5, idAutor = 1, titulo = "Estress na mente" });

            var listaJoin = from livros in listaLivros join autor in listaAutores on livros.idAutor equals autor.id select new {livros, autor};

            foreach (var item in listaJoin)
            {
                Console.WriteLine("Livro: " + item.livros.titulo + " - Autor: " + item.autor.nome);
            }

            Console.ReadKey();
        }
    }
}
