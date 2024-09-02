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

            //IMPLEMENTADO
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
        Console.WriteLine("Digite a placa do veículo para remover:");

        // Pedir para o usuário digitar a placa e armazenar na variável placa
        string placa = Console.ReadLine();
    
        // Verifica se o veículo existe
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

        // Lê o número de horas e converte para inteiro
        int horas = int.Parse(Console.ReadLine()); 
        
        // Calcula o valor total
        decimal valorTotal = precoInicial + (precoPorHora * horas); 

        // Remove a placa da lista de veículos
        veiculos.Remove(placa); 

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
            if (veiculos.Any())
            {
             Console.WriteLine("Os veículos estacionados são:");
        
            // Laço de repetição para exibir cada veículo estacionado
            foreach (var veiculo in veiculos)
            {
            Console.WriteLine(veiculo); // Exibe a placa do veículo
            }
            }
            else // Certifique-se de que não há erro de sintaxe aqui
            {
            Console.WriteLine("Não há veículos estacionados.");
            }
         }
    }
}