using Biblioteca.Domain.Enums;
using Biblioteca.Domain.Models.ValueObjects;

namespace Biblioteca.Domain.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; } 
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public int Rg { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public ESexo Sexo { get; set; }
    }
}
