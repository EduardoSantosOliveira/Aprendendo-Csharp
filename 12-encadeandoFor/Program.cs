using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Encadeando For");

        //com break
        for (int contadordeLinha = 1; contadordeLinha <= 10; contadordeLinha++)
        {

            for (int contadordeColuna = 1; contadordeColuna <= 10; contadordeColuna++)
            {
                Console.Write("*");
                if (contadordeColuna >= contadordeLinha)
                    break;
            }
            Console.WriteLine();
        }

        //sem break
        for (int contadordeLinha = 1; contadordeLinha <= 10; contadordeLinha++)
        {

            for (int contadordeColuna = 1; contadordeColuna <= contadordeLinha; contadordeColuna++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();

    }
}