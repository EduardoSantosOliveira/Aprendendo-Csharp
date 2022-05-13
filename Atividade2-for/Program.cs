using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade2 - for");

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            //investimento = investimento + investimento * 0.005;
            investimento *= 1.005;
            Console.WriteLine("No mes voce " + mes + " obteve: R$" + investimento);
        }


        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}