﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Target
{
    internal class Exercicio_3
    {
        public static void Executar()
        {

            int INDICE = 12;
            int SOMA = 0;
            int K = 1;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
                Console.WriteLine(SOMA);

            }
            Console.WriteLine($"\n a quantidade de SOMA é {SOMA}");
        }
    }
}
