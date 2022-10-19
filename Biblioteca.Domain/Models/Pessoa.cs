using Biblioteca.Domain.Enums;
using Biblioteca.Domain.Models.ValueObjects;

namespace Biblioteca.Domain.Models
{
    public abstract class Pessoa
    {
        protected Pessoa(Nome nome, Endereco endereco,  int rg, string cpf, DateTime dataNascimento, string email,  string telefone, ESexo sexo)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Cpf = cpf;
            Rg = rg;
            Email = email;
            DataNascimento = dataNascimento;
            Sexo = sexo;
        }

        public int Id { get; set; }
        public Nome Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public int Rg { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public ESexo Sexo { get; set; }

        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Aluno Aluno { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
