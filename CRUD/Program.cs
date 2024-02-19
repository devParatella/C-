using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Pessoa> listaPessoas = new List<Pessoa>();

        while (true)
        {
            Console.WriteLine("\n*** Menu ***");
            Console.WriteLine("1. Cadastrar Pessoa");
            Console.WriteLine("2. Exibir Relatório");
            Console.WriteLine("3. Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarPessoa(listaPessoas);
                    break;

                case "2":
                    ExibirRelatorio(listaPessoas);
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CadastrarPessoa(List<Pessoa> listaPessoas)
    {
        Console.WriteLine("\n*** Cadastro de Pessoa ***");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        if (!int.TryParse(Console.ReadLine(), out int idade) || idade <= 0)
        {
            Console.WriteLine("Idade inválida. Insira um valor válido.");
            return;
        }

        Console.Write("Cargo (Funcionário/Cliente/Prestador de Serviço): ");
        string cargo = Console.ReadLine();

        Pessoa pessoa;

        switch (cargo.ToLower())
        {
            case "funcionário":
                pessoa = CadastrarFuncionario();
                break;

            case "cliente":
                pessoa = CadastrarCliente();
                break;

            case "prestador de serviço":
                pessoa = CadastrarPrestadorServico();
                break;

            default:
                Console.WriteLine("Cargo inválido. Cadastro não realizado.");
                return;
        }

        pessoa.Nome = nome;
        pessoa.Idade = idade;

        listaPessoas.Add(pessoa);

        Console.WriteLine("Cadastro realizado com sucesso!");
    }

    static void ExibirRelatorio(List<Pessoa> listaPessoas)
    {
        Console.WriteLine("\n*** Relatório ***");

        foreach (var pessoa in listaPessoas)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Cargo: {pessoa.ObterCargo()}");
        }
    }

    static Funcionario CadastrarFuncionario()
    {
        Console.Write("Cargo do Funcionário (Gerente/Diretor/Vendedor/Programador/Outros): ");
        string cargoFuncionario = Console.ReadLine();

        switch (cargoFuncionario.ToLower())
        {
            case "gerente":
                return new Gerente();

            case "diretor":
                return new Diretor();

            case "vendedor":
                return new Vendedor();

            case "programador":
                return new Programador();

            default:
                return new Funcionario();
        }
    }

    static Cliente CadastrarCliente()
    {
        Console.Write("Categoria do Cliente (VIP/Premium/Master/Outros): ");
        string categoriaCliente = Console.ReadLine();

        switch (categoriaCliente.ToLower())
        {
            case "vip":
                return new ClienteVIP();

            case "premium":
                return new ClientePremium();

            case "master":
                return new ClienteMaster();

            default:
                return new Cliente();
        }
    }

    static PrestadorServico CadastrarPrestadorServico()
    {
        Console.Write("Tipo de Serviço: ");
        string tipoServico = Console.ReadLine();

        return new PrestadorServico(tipoServico);
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public virtual string ObterCargo()
    {
        return "Indefinido";
    }
}

class Funcionario : Pessoa
{
    public override string ObterCargo()
    {
        return "Funcionário";
    }
}

class Gerente : Funcionario
{
    public override string ObterCargo()
    {
        return "Gerente";
    }
}

class Diretor : Funcionario
{
    public override string ObterCargo()
    {
        return "Diretor";
    }
}

class Vendedor : Funcionario
{
    public override string ObterCargo()
    {
        return "Vendedor";
    }
}

class Programador : Funcionario
{
    public override string ObterCargo()
    {
        return "Programador";
    }
}

class Cliente : Pessoa
{
    public override string ObterCargo()
    {
        return "Cliente";
    }
}

class ClienteVIP : Cliente
{
    public override string ObterCargo()
    {
        return "Cliente VIP";
    }
}

class ClientePremium : Cliente
{
    public override string ObterCargo()
    {
        return "Cliente Premium";
    }
}

class ClienteMaster : Cliente
{
    public override string ObterCargo()
    {
        return "Cliente Master";
    }
}

class PrestadorServico : Pessoa
{
    public string TipoServico { get; private set; }

    public PrestadorServico(string tipoServico)
    {
        TipoServico = tipoServico;
    }

    public override string ObterCargo()
    {
        return $"Prestador de Serviço ({TipoServico})";
    }
}
