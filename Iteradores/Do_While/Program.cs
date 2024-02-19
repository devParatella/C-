using System;

class Program
{
    static void Main()
    {
        int dayOfWeek = 1; // Inicializando com o primeiro dia da semana (Domingo)

        do
        {
            Console.WriteLine(GetDayOfWeekName(dayOfWeek));
            dayOfWeek++;

            // Se atingir o último dia da semana (Sábado), reinicia no primeiro dia (Domingo)
            if (dayOfWeek > 7)
                dayOfWeek = 1;

        } while (dayOfWeek != 1); // Continua enquanto não voltar ao Domingo
    }

    static string GetDayOfWeekName(int dayOfWeek)
    {
        switch (dayOfWeek)
        {
            case 1:
                return "Domingo";
            case 2:
                return "Segunda-feira";
            case 3:
                return "Terça-feira";
            case 4:
                return "Quarta-feira";
            case 5:
                return "Quinta-feira";
            case 6:
                return "Sexta-feira";
            case 7:
                return "Sábado";
            default:
                return "Dia inválido";
        }
    }
}
