string numeroString = "abc";
int numero;

if (int.TryParse(numeroString, out numero))
{
    // Código a ser executado se a conversão for bem-sucedida
    Console.WriteLine("Conversão bem-sucedida: " + numero);
}
else
{
    // Código a ser executado se a conversão falhar
    Console.WriteLine("Falha na conversão. Tratando de forma específica.");
}
bool _ = int.TryParse(numeroString, out numero);