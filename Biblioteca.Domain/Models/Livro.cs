namespace Biblioteca.Domain.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Edicao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Autores { get; set; }
        public string Categoria { get; set; }
        public int Estoque { get; set; }
        public bool Alugado { get; set; }

    }
    
}
