namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if(Suite.Capacidade >= hospedes.Count){
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("Número de hóspedes é menor que a capacidade");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int inquilinos = Hospedes.Count;
            return inquilinos;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * (Suite.ValorDiaria);

            if (DiasReservados >= 10)
            {
                return valorTotal = (valorTotal - valorTotal/10);
            }

            return valorTotal;
        }
    }
}