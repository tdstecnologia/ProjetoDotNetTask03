using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTaskDevelopers03.Claudia
{
    class ContadorDePalavras29
    {
        public static void Executar()
        {
            string texto = "lorem ipsum dolor sit amet lorem ipsum dolor sit amet";
            Console.WriteLine("Quantidade de palavras: " + texto.Split(" ").Length);
        }
    }
}
