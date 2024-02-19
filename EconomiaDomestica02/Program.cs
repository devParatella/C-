using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criar uma instância da classe ControleFinanceiro
        ControleFinanceiro controleFinanceiro = new ControleFinanceiro();

        // Menu principal
        while (true)
        {
            Console.WriteLine("======== Controle Financeiro Doméstico ========");
            Console.WriteLine("1. Adicionar Receita");
            Console.WriteLine("2. Adicionar Despesa");
            Console.WriteLine("3. Adicionar Item à Lista de Compras");
            Console.WriteLine("4. Exibir Relatório de Gastos");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Informe o valor da receita: ");
                    if (double.TryParse(Console.ReadLine(), out double valorReceita))
                    {
                        controleFinanceiro.AdicionarReceita(valorReceita);
                        Console.WriteLine("Receita adicionada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Por favor, insira um número válido.");
                    }
                    break;

                case "2":
                    Console.Write("Informe o valor da despesa: ");
                    if (double.TryParse(Console.ReadLine(), out double valorDespesa))
                    {
                        controleFinanceiro.AdicionarDespesa(valorDespesa);
                        Console.WriteLine("Despesa adicionada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Por favor, insira um número válido.");
                    }
                    break;

                case "3":
                    Console.Write("Informe o item da lista de compras: ");
                    string? itemListaCompras = Console.ReadLine();
                    Console.Write("Informe a unidade de medida (ex: L, Kg, etc.): ");
                    string? unidadeMedida = Console.ReadLine();
                    Console.Write("Informe a quantidade: ");
                    if (double.TryParse(Console.ReadLine(), out double quantidade))
                    {
                        Console.Write("Informe o valor unitário: ");
                        if (double.TryParse(Console.ReadLine(), out double valorUnitario))
                        {
                            controleFinanceiro.AdicionarItemListaCompras(itemListaCompras!, unidadeMedida!, quantidade, valorUnitario);
                            Console.WriteLine("Item adicionado à lista de compras com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Valor unitário inválido. Por favor, insira um número válido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Quantidade inválida. Por favor, insira um número válido.");
                    }
                    break;

                case "4":
                    controleFinanceiro.ExibirRelatorio();
                    break;

                case "5":
                    Console.WriteLine("Saindo do programa. Até mais!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }

            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

class ControleFinanceiro
{
    private double saldo;
    private List<string> listaCompras;
    private Dictionary<string, double> gastos;

    public ControleFinanceiro()
    {
        saldo = 0.0;
        listaCompras = new List<string>();
        gastos = new Dictionary<string, double>();
    }

    public void AdicionarReceita(double valor)
    {
        saldo += valor;
    }

    public void AdicionarDespesa(double valor)
    {
        saldo -= valor;
    }

    public void AdicionarItemListaCompras(string item, string unidadeMedida, double quantidade, double valorUnitario)
    {
        double valorTotal = quantidade * valorUnitario;
        saldo -= valorTotal; // Deduzir o valor total da compra do saldo
        listaCompras.Add($"{item} ({quantidade} {unidadeMedida}): {valorTotal:C}");
    }

    public void ExibirRelatorio()
    {
        Console.WriteLine("\n======== Relatório de Gastos ========");
        Console.WriteLine($"Saldo Atual: {saldo:C}");

        Console.WriteLine("\nDespesas:");
        foreach (var despesa in gastos)
        {
            Console.WriteLine($"{despesa.Key}: -{despesa.Value:C} (em vermelho)");
        }

        Console.WriteLine("\nLista de Compras:");
        foreach (var item in listaCompras)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
