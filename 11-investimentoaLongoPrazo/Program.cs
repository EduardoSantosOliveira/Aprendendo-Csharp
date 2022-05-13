using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Investimento a Longo Prazo");

        double fatordeRedimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {

            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatordeRedimento;
                Console.WriteLine("__________________");
                Console.WriteLine("No mês " + mes + " do ano: " + anos + " valor " + Math.Round(investimento));

            }
            fatordeRedimento += 0.001;
        }
        Console.WriteLine("__________________");
        Console.WriteLine("depois de 5 anos voce tera R$" + Math.Round(investimento));

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}