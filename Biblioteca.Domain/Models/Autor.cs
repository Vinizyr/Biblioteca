using Biblioteca.Domain.Models.ValueObjects;

namespace Biblioteca.Domain.Models
{
    public class Autor : Pessoa
    {
        public Autor(Nome nome, Endereco endereco, int rg, string cpf, DateTime dataNascimento, 
            string email, string telefone)
            : base(nome, endereco, rg, cpf, dataNascimento, email, telefone)
        {
            
        }

        public int PessoaId { get; private set; }
        public virtual Pessoa Pessoa { get; private set; }
    }
}
