namespace Biblioteca.Domain.Models
{
    public class Devolucao
    {
        public int DevolucaoId { get; set; }
        public float? MultaAtraso { get; set; }

        public int EmprestimoId { get; set; }
        public virtual Emprestimo Emprestimo { get; set; }
    }
}
