// foreach:
// A estrutura de repetição foreach é usada para iterar sobre elementos em coleções, como arrays, listas, etc.
int[] numeros = { 1, 2, 3, 4, 5 };
Console.WriteLine("Foreach:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}


// Gerenciamento de Loop
// break: Encerra imediatamente o loop.
// continue: Pula para a próxima iteração do loop.
Console.WriteLine("Gerenciamento de Loop:");
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        break; // Encerra o loop quando i atinge 5

    if (i % 2 == 0)
        continue; // Pula para a próxima iteração se i é par

    Console.WriteLine(i);
}
