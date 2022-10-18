using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Models.ValueObjects
{
    public class Nome
    {
        public Nome(string nome, string sobrenome)
        {
            primeiroNome = nome;
            Sobrenome = sobrenome;
        }
        public string primeiroNome { get; set; }
        public string Sobrenome { get; set; }
    }
}

