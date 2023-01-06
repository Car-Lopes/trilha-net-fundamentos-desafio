namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine(); //Eu implementei
            veiculos.Add(placa); //Eu implementei
            Console.WriteLine($"Placa {placa} add com sucesso"); //Eu implementei
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string plca = Console.ReadLine();
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = plca; //Eu implementei

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = Convert.ToInt32(Console.ReadLine()); //Eu implementei
                 decimal somaValor = (precoInicial + precoPorHora) * horas; //Eu implementei
                decimal valorTotal = somaValor; //Eu implementei

                // Remover a placa digitada da lista de veículos

                Console.WriteLine($"O veículo {placa} foi removido e permaneceu {horas} horas " +//Eu implementei
                  $"somando o valor da diaria que é {precoInicial} reais + Valor por hora {precoPorHora} reais " +//Eu implementei
                  $"e o preço total foi de: R$ {valorTotal}"); //Eu implementei
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                
                Console.WriteLine($"Os veículos estacionados são:");
                // Realizar um laço de repetição, exibindo os veículos estacionados
                int i = 0; //Eu implementei
                foreach(var veiculo in veiculos) //Eu implementei
                {
                    Console.WriteLine(veiculo);//Eu implementei
                    i++;//Eu implementei
                }
            }      
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
