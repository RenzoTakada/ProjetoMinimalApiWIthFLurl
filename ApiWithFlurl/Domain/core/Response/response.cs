namespace ApiWithFlurl.Domain.core.Response
{
    public struct response
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string nomeCliente { get; set; }
        public double Saldo { get; set; }
        public DateTime DataNasc { get; set; }
        public string cpf { get; set; }
        public int tipoConta { get; set; }
        public string nomeEmpresa { get; set; }
    }
}
