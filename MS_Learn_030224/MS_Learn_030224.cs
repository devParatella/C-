

class Program
{
    private static void Main(string[] args)
    {
        //criando uma instância de classe 
        //Random dice = new Random();

        chamando o método Next
        int roll = dice.Next(1, 2);
        Console.WriteLine(roll);
        //Console.WriteLine(Random.Next(1, 999999999));//funcionou assim tb.
        //Console.WriteLine(dice.next(1, 9999999999));
        //dice.next(1, 9999999999)//ignorar o valor de retorno seria inútil. 
    }
}