using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 04 - conversões e Outros Tipos");

        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        int salrioInteiro;
        salrioInteiro = (int)salario;
        Console.WriteLine(salrioInteiro);
        // o long é um tipo de variável de 64 bits

        long x;
        x = 200000;
        Console.WriteLine(x);

        short y;
        y = 150;
        Console.WriteLine(y);

        float altura;
        altura = 1.72f;
        Console.WriteLine(altura);

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}