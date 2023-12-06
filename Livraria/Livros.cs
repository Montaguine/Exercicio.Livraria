using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercicio.Livraria
{
    internal class Livros
    {
        public string ISBN;
        public string titulo;
        public List<string> autores;
        public int paginas;
        public string editora;
        public string edicao;
        public bool disponivel;
        public string genero;

        public Livros(string titulo, List<string> autores)
        {
            this.autores = autores;
            this.titulo = titulo;
            this.disponivel = true;
        }

        public Livros(string titulo, params string[] autores)
        {
            List<string> ListaAutores = new List<string>();
            ListaAutores.AddRange(autores);
            this.autores = ListaAutores;
            this.titulo = titulo;
            this.disponivel = true;
        }
        public Livros(string titulo, int paginas, bool disponivel, params string[]autores)
        {
            List<string> ListaAutores = new List<string>();
            ListaAutores.AddRange(autores);
            this.autores = ListaAutores;
            this.titulo = titulo;
            this.disponivel = disponivel;
            this.paginas = paginas;
        }

        public bool EstaDisponivel()
        {
            return this.disponivel;
        }

        public string GetTitulo()
        {
            return this.titulo;
        }
        public List<string> GetAutores()
        {
            return this.autores;
        }
        public void SetGenero(string genero)
        {
            this.genero = genero;
        }

        public override string ToString()
        {
            return "Titulo: " + this.titulo + "\n" +
                   "Autores: " + string.Join(",", this.autores) + "\n" +
                   "Paginas: " + this.paginas + "\n" +
                   "Editora: " + this.editora + "\n" +
                   "Edicao: " + this.edicao + "\n" +
                   "Genero: " + this.genero + "\n";
        }
    }
}
