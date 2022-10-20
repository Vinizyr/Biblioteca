namespace Biblioteca.Domain.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Edicao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Autores { get; set; }
        public string Categoria { get; set; }
        public int Estoque { get; set; }

        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; }

        public int EditoraId { get; set; }
        public Editora Editora { get; set; }
    }
    
}
