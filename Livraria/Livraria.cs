using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Livraria
{
    internal class Livraria
    {
        int acervo { get; set;}
        int emprestados { get; set; }
        List<Livros>? livrosEmprestados { get; set; }
        List<Livros>? livrosAcervo { get; set; }
        List <Pessoas>? funcionarios { get; set; }
        string? nome { get; set;}
        readonly string cnpj;
        string? endereco { get; set;}


        public string GetCnpj()
        {
            return this.cnpj;
        }

        public Livraria(string nome, string cnpj)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.endereco = endereco;
            List<Livros> livrosAcervo = new List<Livros>();
            List<Pessoas> funcionarios = new List<Pessoas>();
            List<Livros> livrosEmprestados = new List<Livros>();
            this.funcionarios = funcionarios;
            this.livrosAcervo = livrosAcervo;
            this.livrosEmprestados = livrosEmprestados;
        }

        public Livraria(string nome, string cnpj, string endereco)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.endereco = endereco;
            List<Livros> livrosAcervo = new List<Livros>();
            List<Pessoas> funcionarios = new List<Pessoas>();
            List<Livros> livrosEmprestados = new List<Livros>();
            this.funcionarios = funcionarios;
            this.livrosAcervo = livrosAcervo;
            this.livrosEmprestados = livrosEmprestados;
        }

        public Livros CadastrarLivro(string titulo, List<string>autores)
        {
            return new Livros(titulo, autores);
        }
        public void AdicionarLivro(string titulo, List<string>autores)
        {
            livrosAcervo?.Add(CadastrarLivro(titulo, autores));
            this.acervo++;
        }
        public void EmprestarLivro()
        {

        }
        public void DevolverLivro()
        {

        }
        public void RemoverLivro(string titulo)
        {
            livrosAcervo.Remove(livrosAcervo.Find(livros => livros.titulo == titulo));
            this.acervo--;
        }
        
        public void ListarEmprestados()
        {
            livrosEmprestados?.ForEach(livros => Console.WriteLine(livros.titulo));
        }
        public void ListarAcervo()
        {
            livrosAcervo?.ForEach(livros => Console.WriteLine(livros.ToString()));
        }
    }
}
