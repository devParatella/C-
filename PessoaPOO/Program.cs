using System;
using System.Collections.Generic;

// Classe base Pessoa
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método virtual para exibir informações
    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}

// Subclasse Funcionario que herda de Pessoa
class Funcionario : Pessoa
{
    public string Cargo { get; set; }

    // Construtor
    public Funcionario(string nome, int idade, string cargo) : base(nome, idade)
    {
        Cargo = cargo;
    }

    // Sobrescreve o método ExibirInformacoes da classe base
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Funcionário - Nome: {Nome}, Idade: {Idade}, Cargo: {Cargo}");
    }
}

// Subclasse Cliente que herda de Pessoa
class Cliente : Pessoa
{
    public string Categoria { get; set; }

    // Construtor
    public Cliente(string nome, int idade, string categoria) : base(nome, idade)
    {
        Categoria = categoria;
    }

    // Sobrescreve o método ExibirInformacoes da classe base
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Cliente - Nome: {Nome}, Idade: {Idade}, Categoria: {Categoria}");
    }
}

// Classe principal
class Program
{
    static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        // Criação de instâncias de diferentes tipos
        Funcionario gerente = new Funcionario("João", 35, "Gerente");
        Cliente clienteVIP = new Cliente("Maria", 28, "VIP");
        Funcionario programador = new Funcionario("Carlos", 30, "Programador");
        Cliente clienteMaster = new Cliente("Ana", 40, "Master");

        // Adiciona as instâncias à lista de pessoas
        pessoas.Add(gerente);
        pessoas.Add(clienteVIP);
        pessoas.Add(programador);
        pessoas.Add(clienteMaster);

        // Itera sobre a lista e exibe as informações de cada pessoa
        foreach (var pessoa in pessoas)
        {
            pessoa.ExibirInformacoes();
        }
    }
}
