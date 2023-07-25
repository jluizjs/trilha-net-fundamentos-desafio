using DesafioFundamentos.Models.Interfaces;

namespace DesafioFundamentos.Models
{
    public class Estacionamento: IEstacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> Veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if(Veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
                Console.WriteLine($"O veículo de palca {placa} já está registrado.");
            }else {
                Veiculos.Add(placa);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            
            // Verifica se o veículo existe
            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");               
                int horas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Valores:");
                Console.WriteLine($"Taxa inicial:{precoInicial}");
                Console.WriteLine($"Valor por Hora:{precoPorHora}");
                Console.WriteLine($"Tempo estacionado:{horas}");
                decimal valorTotal = (horas * precoPorHora) + precoInicial;
                Console.WriteLine($"Total: {valorTotal}"); 

                Veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string veiculo in Veiculos){
                    Console.WriteLine($"Placa: {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
