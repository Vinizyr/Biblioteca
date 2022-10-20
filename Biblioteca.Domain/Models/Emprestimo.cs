namespace Biblioteca.Domain.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
        public int AtendenteId { get; set; }
        public virtual Pessoa Atendente { get; set; } // quem atendeu 
        public int PessoaEmprestimoId { get; set; }
        public virtual Pessoa PessoaEmprestimo { get; set; } // quem pegou o livro emprestado
        public int LivroId { get; set; }
        public virtual Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataMaximaDevolucao { get; set; }
        public DateTime? DataDevolucao { get; set; }
    }
}
