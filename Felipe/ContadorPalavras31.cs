using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTaskDevelopers03.Felipe
{
    class ContadorPalavras31
    {
         public static void ContaPalavra()
        {
            string texto = "Sou o melhor no que faço, mas o que eu faço não é o melhor";
            Console.WriteLine("A quantidade de palavras é: {0}",(texto.Split(" ")).Length);
        }
    }
}
