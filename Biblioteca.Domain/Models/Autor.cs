using Biblioteca.Domain.Enums;
using Biblioteca.Domain.Models.ValueObjects;

namespace Biblioteca.Domain.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }

        public int LivroId { get; set; }
        public virtual Livro Livro { get; set; }
    }
}
