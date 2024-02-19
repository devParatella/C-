using System;

class Program
{
    static void Main()
    {
        // Chamada inicial para a função recursiva
        ImprimirImpares(0);

        // Aguarda a entrada do usuário antes de fechar o console
        Console.ReadLine();
    }

    static void ImprimirImpares(int numero)
    {
        // Caso base: se o número ultrapassar 100, encerra a recursão
        if (numero > 100)
            return;

        // Verifica se o número é ímpar e imprime na tela
        if (numero % 2 != 0)
            Console.WriteLine(numero);

        // Chama recursivamente a função com o próximo número
        ImprimirImpares(numero + 1);
    }
}
