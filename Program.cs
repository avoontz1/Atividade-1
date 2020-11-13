using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Dígite sua idade");
            int idade = int.Parse(Console.ReadLine() );
    
            int meses = (idade * 12);
            int dias = idade * 365;
            int horas = dias * 24;
            int minutos = horas * 60;

            System.Console.WriteLine("Idade em meses: " +meses);
            System.Console.WriteLine("Idade em dias" +dias);
            System.Console.WriteLine("Idade em horas" +horas);
            System.Console.WriteLine("Idade em minutos" +minutos);

        }
    }
}
