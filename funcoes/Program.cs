//  Função - Sintaxe de uma função:
//  tipoRetorno NomeDaFuncao(parâmetros)
//  {
//       // Corpo da função
//       // Código que realiza a tarefa
//       return resultado; // Se houver um tipo de retorno
//  }

static int calculoSoma(int valorA, int valorB)
{
    return valorA + valorB;
}

int resultado = calculoSoma(5, 3);

Console.WriteLine("O resultado da soma é: " + resultado);
