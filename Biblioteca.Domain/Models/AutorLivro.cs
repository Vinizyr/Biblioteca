namespace Biblioteca.Domain.Models
{
    public class AutorLivro
    {
        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; }

        public int LivroId { get; set; }
        public virtual Livro Livro { get; set; }

    }
}
