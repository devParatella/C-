/*int contador1 = 0;
Console.WriteLine("While:");
while (contador1 < 5)
{
    Console.WriteLine(contador1);
    contador1++;
}

int contador2 = 5;
Console.WriteLine("do-While:");
do
{
    Console.WriteLine("contador2:");
    contador2++;
}
while (contador2 < 5);
{
    Console.WriteLine(contador2);
    contador1++;
}

int segundos1 = 0;
while (segundos1 < 60)
{
    Console.WriteLine(segundos1);
}
*/
int segundos2 = 60;
do
{
    segundos2++;
    Console.WriteLine("Do-While");
}
while (segundos2 < 60);

Console.WriteLine(segundos2);
string? escolhausuario = "";
bool escolha = true;
Console.WriteLine("Escolha uma opção: ");
while (escolha)
{
    Console.WriteLine("1. Café");
    Console.WriteLine("2. Chocolate");
    Console.WriteLine("3. Sair");
    escolhausuario = Console.ReadLine();

    if (escolhausuario == "1") {
        Console.WriteLine("Café");
    }
    else if(escolhausuario == "2") {
        Console.WriteLine("Chocolate");
    }
    else if(escolhausuario == "3") {
        escolha = false;
    }
    else {
        Console.WriteLine("Valor inválido");
    }

}
Console.WriteLine("Encerrou o código no valor: " + escolhausuario);