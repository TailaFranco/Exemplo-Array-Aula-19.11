using System;

namespace Exemplo_array___Aula_19._11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa para exemplificar o uso do array
            // Array permite salvar diversos valores para uma mesma variável apenas mudando a posição de onde será salva.
           
            Console.WriteLine("Exemplo Array");

        string[] nomes = new string[5];
        int[] idades = new int[5];

        for (var contator = 0; contator < 5; contator++)
        {
            Console.WriteLine($"Digite o {contator+1}º nome");
            nomes[contator] = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            idades[contator] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Dados salvos:");
        for (var contator = 0; contator < 5; contator++)
        {   
            
            Console.WriteLine("Nome: " +nomes[contator]);
            Console.WriteLine("Idade: " +idades[contator]);
        }
        }
    }
}
