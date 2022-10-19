namespace Biblioteca.Domain.Models
{
    public class DevolucaoLivro
    {
        public int DevolucaoId { get; set; }
        public int EmprestimoId { get; set; }        
        public float? MultaAtraso { get; set; }
    }
}
