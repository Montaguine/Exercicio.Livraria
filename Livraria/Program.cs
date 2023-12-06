namespace Exercicio.Livraria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindos a nossa livraria publica do Tolkien");
            Livraria livraria = new Livraria("Livraria do João", "123456789");

            livraria.AdicionarLivro("O Senhor dos Anéis", new List<string>() { "J. R. R. Tolkien" });
            livraria.AdicionarLivro("O Hobbit", new List<string>() { "J. R. R. Tolkien", "Nós três" });
            Console.WriteLine("\n2 livros adicionados\n");
            livraria.ListarAcervo();
            livraria.RemoverLivro("O Hobbit");
            Console.WriteLine("\n1 livro removido\n");
            livraria.ListarAcervo();


        }
    }
}
