using Biblioteca.Domain.Enums;
using Biblioteca.Domain.Models.ValueObjects;

namespace Biblioteca.Domain.Models
{
    public class Professor : Pessoa
    {
        public Professor(Nome nome, Endereco endereco, int rg, string cpf, DateTime dataNascimento, string email, string telefone, ESexo sexo) 
            : base(nome, endereco, rg, cpf, dataNascimento, email, telefone, sexo)
        {

        }

        public string Titulacao { get; set; }
        public int CarteiraTrabalho { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
