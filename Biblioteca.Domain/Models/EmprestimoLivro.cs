namespace Biblioteca.Domain.Models
{
    public class EmprestimoLivro
    {
        public int EmprestimoLivroId { get; set; }
        public int AtendenteId { get; set; }
        public virtual Pessoa Atendente { get; set; }
        public int PessoaEmprestimoId { get; set; }
        public virtual Pessoa PessoaEmprestimo { get; set; }
        public int LivroId { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataMaximaDevolucao { get; set; }
        public DateTime? DataDevolucao { get; set; }
    }
}
