using System.Globalization; // Adiciona a biblioteca para manipulação de formatos de moeda

class Program
{
    static void Main()
    {
        do
        {
            Console.Clear(); // Limpa o console no início de cada iteração do loop
            Console.WriteLine("Conversor de Moedas");

            double valorEmReais;

            do
            {
                Console.Write("Digite o valor em reais: ");
            } while (!double.TryParse(Console.ReadLine(), out valorEmReais) || valorEmReais <= 0);

            if (valorEmReais <= 0)
            {
                Console.WriteLine("Valor inválido. Por favor, digite um valor maior que zero.");
                continue; // Reinicia o loop para obter um valor válido
            }

            string moedaDestino;
            double taxaConversao = 0;

            do
            {
                Console.Write("Escolha a moeda para a qual quer converter (USD, EUR, GBP): ");
                moedaDestino = Console.ReadLine()!.ToUpper();

                switch (moedaDestino)
                {
                    case "USD":
                        taxaConversao = 5.5;
                        break;
                    case "EUR":
                        taxaConversao = 6.2; // Substitua pela taxa de conversão desejada para Euros
                        break;
                    case "GBP":
                        taxaConversao = 7.8; // Substitua pela taxa de conversão desejada para Libras Esterlinas
                        break;
                    default:
                        Console.WriteLine("Moeda de destino inválida. Tente novamente.");
                        break;
                }
            } while (taxaConversao == 0);

            double valorConvertido = valorEmReais / taxaConversao;

            // Formata o valor convertido para o formato de moeda da cultura corrente
            string moedaFormato = "";

            if (moedaDestino == "USD")
            {
                moedaFormato = "en-US";
            }
            else if (moedaDestino == "EUR")
            {
                moedaFormato = "es-ES";
            }
            else if (moedaDestino == "GBP")
            {
                moedaFormato = "en-GB";
            }

            string valorFormatado = valorConvertido.ToString("C", CultureInfo.CreateSpecificCulture(moedaFormato));

            Console.WriteLine($"O valor em {moedaDestino} é: {valorFormatado}");
            Console.WriteLine("Pressione ESC para sair ou qualquer tecla para converter novamente");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        Console.Clear();
    }
}
