using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criação de uma lista para armazenar transações (gastos ou receitas)
        List<Transacao> transacoes = [];

        // Loop principal do programa
        while (true)
        {
            // Exibe o menu para o usuário
            ExibirMenu();

            // Lê a escolha do usuário
            char escolha = Console.ReadKey().KeyChar;

            // Limpa a tela para uma melhor experiência do usuário
            Console.Clear();

            // Executa a ação com base na escolha do usuário
            switch (escolha)
            {
                case '1':
                    RegistrarTransacao(transacoes);
                    break;
                case '2':
                    ExibirRelatorio(transacoes);
                    break;
                case '3':
                    // Adicione mais opções conforme necessário
                    break;
                case '0':
                    // Sai do programa se o usuário escolher '0'
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    // Método para exibir o menu
    static void ExibirMenu()
    {
        Console.WriteLine("=== Controle de Gastos e Receitas ===");
        Console.WriteLine("1. Registrar Transação");
        Console.WriteLine("2. Exibir Relatório");
        Console.WriteLine("3. Outras opções (personalize conforme necessário)");
        Console.WriteLine("0. Sair");
        Console.Write("Escolha uma opção: ");
    }

    // Método para registrar uma nova transação
    static void RegistrarTransacao(List<Transacao> transacoes)
    {
        Console.Write("Digite o valor da transação: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal valor))
        {
            Console.Write("Digite 'D' para débito ou 'C' para crédito: ");
            char tipo = char.ToUpper(Console.ReadKey().KeyChar);

            Console.Write("\nDigite a data da transação (dd/mm/aaaa): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
            {
                // Adiciona a transação à lista
                transacoes.Add(new Transacao(valor, tipo, data));

                Console.WriteLine("\nTransação registrada com sucesso!\n");
            }
            else
            {
                Console.WriteLine("\nData inválida. Transação não registrada.\n");
            }
        }
        else
        {
            Console.WriteLine("\nValor inválido. Transação não registrada.\n");
        }
    }

    // Método para exibir um relatório personalizado
    static void ExibirRelatorio(List<Transacao> transacoes)
    {
        // Lógica para exibir relatório conforme necessário
        // Este é um exemplo simples, você pode personalizá-lo conforme sua necessidade
        Console.WriteLine("=== Relatório de Transações ===");
        foreach (var transacao in transacoes)
        {
            Console.WriteLine($"Data: {transacao.Data.ToShortDateString()} | Valor: {transacao.Valor.ToString("C")} | Tipo: {transacao.Tipo}");
        }
        Console.WriteLine();
    }
}

// Classe para representar uma transação
class Transacao
{
    public decimal Valor { get; set; }
    public char Tipo { get; set; } // 'D' para débito, 'C' para crédito
    public DateTime Data { get; set; }

    public Transacao(decimal valor, char tipo, DateTime data)
    {
        Valor = valor;
        Tipo = tipo;
        Data = data;
    }
}
