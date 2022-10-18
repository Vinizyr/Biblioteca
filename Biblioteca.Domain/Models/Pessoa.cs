using Biblioteca.Domain.Models.ValueObjects;

namespace Biblioteca.Domain.Models
{
    public abstract class Pessoa
    {
        protected Pessoa(Nome nome, Endereco endereco,  int rg, string cpf, DateTime dataNascimento, string email,  string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Cpf = cpf;
            Rg = rg;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public int Id { get; set; }
        public Nome Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public int Rg { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }


    }
}
