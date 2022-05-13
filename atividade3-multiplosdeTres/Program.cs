using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade3 - Multiplos de Tres");

        int numero = 100;


        for (int i = 3; i <= numero; i += 3)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}