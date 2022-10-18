using Biblioteca.Domain.Models.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Models
{
    public class Professor : Pessoa
    {
        public Professor(Nome nome, Endereco endereco, int rg, string cpf, DateTime dataNascimento, string email, string telefone) 
            : base(nome, endereco, rg, cpf, dataNascimento, email, telefone)
        {

        }

        public string Titulacao { get; set; }
        public int CarteiraTrabalho { get; set; }


    }
}
