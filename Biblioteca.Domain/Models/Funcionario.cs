using Biblioteca.Domain.Enums;
using Biblioteca.Domain.Models.ValueObjects;

namespace Biblioteca.Domain.Models
{
    public class Funcionario : Pessoa
    {
        public Funcionario(Nome nome, 
            Endereco endereco, int rg, 
            string cpf, DateTime dataNascimento, 
            string email, string telefone, string carteiraTrabalho, DateTime dataContratacao, ESexo sexo)
            : base(nome, endereco, rg, cpf, dataNascimento, email, telefone, sexo)
        {
            CarteiraTrabalho = carteiraTrabalho;
            DataContratacao = dataContratacao;
        }

        public string CarteiraTrabalho { get; set; }
        public DateTime DataContratacao { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
