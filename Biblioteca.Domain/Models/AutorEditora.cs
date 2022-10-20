using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Models
{
    public class AutorEditora
    {
        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; }

        public int EditoraId { get; set; }
        public virtual Editora Editora { get; set; }
    }
}
