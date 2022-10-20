namespace Biblioteca.Domain.Models
{
    public class Editora
    {
        public int EditoraId { get; set; }
        public string NomeEditora { get; set; }
        public DateTime DataFundacao { get; set; }
        public string NomeFundadores { get; set; }


        public int LivroId { get; set; }
        public virtual Livro Livro { get; set; }

        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
