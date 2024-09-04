using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Target
{
    internal class Exercicio_1
    {
        public static void Executar()
        {
            Console.WriteLine("\n");

            Console.WriteLine("Digite um numero para verificar se há na sequencia de Fibonacci:");
            int numeroUsuario = (int.Parse(Console.ReadLine()));

            Console.WriteLine("A sequencia de Fibonacci começa com 0 ,1, 1, 2, 3, 5, ...\n");


            if (PertenceFibonacci(numeroUsuario))
            {
                Console.WriteLine($"{numeroUsuario} pertence a sequencia de Fibonacci\n");
            }
            else
            {
                Console.WriteLine($"{numeroUsuario} não esta na sequencia de Fibonacci\n");
            }
        }

        private static bool PertenceFibonacci(int numeroUsuario)
        {
            int a = 0;
            int b = 1;

            while (a <= numeroUsuario)
            {
                if (a == numeroUsuario)
                {
                    return true;
                }
                int proximoNumero = a + b;
                a = b;
                b = proximoNumero;
            }
            return false;
        }
    }
    }

