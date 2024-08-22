namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados) => DiasReservados = diasReservados;

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {  
            if (hospedes.Count() > Suite.Capacidade)
            {
                throw new Exception($"O número de hospedes ({hospedes.Count()}) é maior que a capacidade da suíte ({Suite.Capacidade})");
            }

            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite) => Suite = suite;

        public int ObterQuantidadeHospedes() => Hospedes.Count();

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            return DiasReservados >= 10 ? valor * 0.9M : valor;
        }
    }
}