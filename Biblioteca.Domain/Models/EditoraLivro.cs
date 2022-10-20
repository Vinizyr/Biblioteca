using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Models
{
    public class EditoraLivro
    {
        public int EditoraId { get; set; }
        public virtual Editora Editora { get; set; }

        public int LivroId { get; set; }
        public virtual Livro Livro { get; set; }
    }
}
