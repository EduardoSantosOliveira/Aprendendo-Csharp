using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 1");

        double n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;

        Console.Write("digite a nota 1: ");
        n1 = double.Parse(Console.ReadLine());

        Console.Write("digite a nota 2: ");
        n2 = double.Parse(Console.ReadLine());

        Console.Write("digite a nota 3: ");
        n3 = double.Parse(Console.ReadLine());


        Console.Write("digite a nota 4: ");
        n4 = double.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;
        double media = (n1 + n2 + n3 + n4) / 4.0;



        if (media >= 6)
        {
            Console.WriteLine("Voçê foi aprovado");
        }
        if (media >= 5.0 && media <= 5.9)
        {
            Console.WriteLine("Voçê esta de recuperação");
        }
        if (media <= 4)
        {
            Console.WriteLine("Voçê foi reprovado");
        }
        Console.WriteLine("A soma notas e: " + res);
        Console.WriteLine("sua media é: " + (double)media, 2f);


        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
