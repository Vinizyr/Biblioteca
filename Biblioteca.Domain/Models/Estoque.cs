﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int QtdLivrosEstoque { get; set; }

        public int LivroId { get; set; }
        public virtual Livro Livro { get; set; }
    }
}
