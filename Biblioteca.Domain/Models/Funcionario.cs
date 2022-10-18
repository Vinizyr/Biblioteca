using Biblioteca.Domain.Models.ValueObjects;

namespace Biblioteca.Domain.Models
{
    public class Funcionario : Pessoa
    {
        public Funcionario(Nome nome, 
            Endereco endereco, int rg, 
            string cpf, DateTime dataNascimento, 
            string email, string telefone, string carteiraTrabalho, DateTime dataContratacao)
            : base(nome, endereco, rg, cpf, dataNascimento, email, telefone)
        {
            CarteiraTrabalho = carteiraTrabalho;
            DataContratacao = dataContratacao;
        }

        public string CarteiraTrabalho { get; set; }
        public DateTime DataContratacao { get; set; }
    }
}
