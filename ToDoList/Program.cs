using System;
using System.Collections.Generic;

class Program
{
    // Lista para armazenar as tarefas
    static List<string> tarefas = new List<string>();

    static void Main()
    {
        Console.WriteLine("Bem-vindo ao ToDoList!");
        
        // Loop principal do programa
        while (true)
        {
            // Exibe o menu de opções
            MostrarMenu();
            // Lê a escolha do usuário
            char escolha = Console.ReadKey().KeyChar;
            
            // Executa a opção escolhida
            switch (escolha)
            {
                case '1':
                    // Adiciona uma nova tarefa à lista
                    AdicionarTarefa();
                    break;
                case '2':
                    // Exibe a lista de tarefas
                    VisualizarTarefas();
                    break;
                case (char)27: // Tecla Escape
                    // Sai do programa
                    SairDoPrograma();
                    break;
                default:
                    // Mensagem para escolhas inválidas
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    // Exibe o menu de opções
    static void MostrarMenu()
    {
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine("1 - Adicionar Tarefa");
        Console.WriteLine("2 - Visualizar Tarefas");
        Console.WriteLine("Pressione 'Escape' para sair");
    }

    // Adiciona uma nova tarefa à lista
    static void AdicionarTarefa()
    {
        Console.Write("\nDigite a nova tarefa: ");
        // Lê a entrada do usuário para a nova tarefa
        string? novaTarefa = Console.ReadLine();
        
        // Verifica se a tarefa não está vazia ou composta apenas por espaços em branco
        if (!string.IsNullOrWhiteSpace(novaTarefa))
        {
            // Adiciona a nova tarefa à lista
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }
        else
        {
            // Mensagem de erro se a tarefa estiver vazia
            Console.WriteLine("A tarefa não pode estar vazia. Tente novamente.");
        }
    }

    // Exibe a lista de tarefas
    static void VisualizarTarefas()
    {
        Console.Clear(); // Limpa o console no início de cada iteração do loop
        Console.WriteLine("\nLista de Tarefas:");
        
        // Verifica se há tarefas na lista
        if (tarefas.Count > 0)
        {
            // Exibe cada tarefa numerada
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }
        }
        else
        {
            // Mensagem se não houver tarefas na lista
            Console.WriteLine("Nenhuma tarefa encontrada.");
        }
    }

    // Sai do programa
    static void SairDoPrograma()
    {
        Console.WriteLine("\nObrigado por usar o ToDoList! Até logo!");
        // Encerra a execução do programa
        Environment.Exit(0);
    }
}
