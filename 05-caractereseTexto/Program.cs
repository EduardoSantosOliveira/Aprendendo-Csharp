using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 05 - Caracteres e Textos");

        char letra;

        letra = (char)69;
        Console.WriteLine(letra);
        letra = (char)68;
        Console.WriteLine(letra);
        letra = (char)85;
        Console.WriteLine(letra);
        letra = (char)65;
        Console.WriteLine(letra);
        letra = (char)82;
        Console.WriteLine(letra);
        letra = (char)68;
        Console.WriteLine(letra);
        letra = (char)79;
        Console.WriteLine(letra);
        Console.WriteLine();


        letra = (char)69;
        Console.Write(letra);
        letra = (char)68;
        Console.Write(letra);
        letra = (char)85;
        Console.Write(letra);
        letra = (char)65;
        Console.Write(letra);
        letra = (char)82;
        Console.Write(letra);
        letra = (char)68;
        Console.Write(letra);
        letra = (char)79;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primeiraFase = "SENAI - Cursos de tecnologias ";
        Console.WriteLine(primeiraFase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Cursos disponíveis: 
-C 
-C++ 
-HTML
-Csharp";
        Console.WriteLine(cursos);

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}