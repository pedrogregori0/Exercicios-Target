using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercicios_Target
{
    internal class Exercicio_2
    {
        public static void Executar()
        {
            Console.WriteLine("\n");

            Console.WriteLine("Digite uma frase qualquer");
            String fraseUsuario = Console.ReadLine();

            int QuantidadeDeAs = 0;

            for (int i = 0; i < fraseUsuario.Length; i++)
            {
                if (fraseUsuario[i] == 'a')
                {
                    QuantidadeDeAs++;
                }

            }
            Console.WriteLine($"A quantidade de 'a' na sua frase é {QuantidadeDeAs}");
        }
    }
}
