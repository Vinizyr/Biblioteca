using Biblioteca.Domain.Enums;
using Biblioteca.Domain.Models.ValueObjects;

namespace Biblioteca.Domain.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(Nome nome, Endereco endereco, int rg, string cpf, DateTime dataNasc, string email, string telefone, string matricula, ESexo sexo) 
            : base( nome,  endereco,  rg,  cpf,  dataNasc,  email,  telefone, sexo)
        {
            Matricula = matricula;
        }
        public string Matricula { get; set; }
        public int PessoaId { get; private set; }
        public virtual Pessoa Pessoa { get; private set; }
    }
}
