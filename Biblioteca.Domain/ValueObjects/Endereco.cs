namespace Biblioteca.Domain.Models.ValueObjects
{
    public class Endereco
    {
        public Endereco(string estado, string cidade, string rua, int numero, int cep, string bairro)
        {
            Estado = estado;
            Cidade = cidade;
            Rua = rua;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;

        }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
    }
}
