using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Target
{
    internal class Exercicio_5
    {
        public static void Executar()
        {
            Console.WriteLine("\n");
            Console.WriteLine("5) Você está em uma sala com três interruptores,");
            Console.WriteLine("cada um conectado a uma lâmpada em salas diferentes. ");
            Console.WriteLine("Você não pode ver as lâmpadas da sala em que está, ");
            Console.WriteLine("mas pode ligar e desligar os interruptores quantas vezes quiser. ");
            Console.WriteLine("Seu objetivo é descobrir qual interruptor controla qual lâmpada. ");
            Console.WriteLine("Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, ");
            Console.WriteLine("qual interruptor controla cada lâmpada? ");


            Console.WriteLine("\nResposta: eu iria deixar apenas um interruptor acionado, e iria ate a sala");
            Console.WriteLine("assim que retornasse iria desligar o ultimo e acionar somente outro");
            Console.WriteLine("fazendo assim sobrar apenas uma lampada e um interruptor pra mesma");
        }
    }
}
