
using Exercicios_Target;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Escolha o exercicio a ser executado:");
        Console.WriteLine("Exercicio 1 - Sequencia de Fibonacci");
        Console.WriteLine("Exercicio 2 - Quantidade de 'a' em uma frase");
        Console.WriteLine("Exercicio 3 - Quantidade da variavel SOMA");
        Console.WriteLine("Exercicio 4 - Descubra a sequencia");
        Console.WriteLine("Exercicio 5 - Interruptores e lampadas");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Exercicio_1.Executar();
                break;
            case "2":
                Exercicio_2.Executar();
                break;
            case "3":
                Exercicio_3.Executar();
                break;
            case "4":
                Exercicio_4.Executar();
                break;
            case "5":
                Exercicio_5.Executar();
                break;
            default: Console.WriteLine("Opção invalida");
                break;
        }
                
    }
}



