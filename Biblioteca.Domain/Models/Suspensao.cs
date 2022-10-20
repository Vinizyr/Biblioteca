namespace Biblioteca.Domain.Models
{
    public class Suspensao
    {
        public int SuspensaoId { get; set; }
        public string MotivoSuspensao { get; set; }
        public string ValorSuspensao { get; set; }
        public DateTime TempoSuspensao { get; set; }
        public DateTime DataFimSuspensao { get; set; }

    }
}
