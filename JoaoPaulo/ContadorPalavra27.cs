using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTaskDevelopers03.JoaoPaulo
{
    public class ContadorPalavra27
    {
        static string frase = "Sou o melhor no que faço, mas o que eu faço não é o melhor";


        public int ContarNumeroPalavra(string frase)
        {
            string[] palavras = frase.Split(' ');
            return palavras.Length;

        }

        public static void Main(String[] args)
        {
            ContadorPalavra27 classe = new ContadorPalavra27();
            int resultado = 0;

            resultado = classe.ContarNumeroPalavra(frase);

            Console.WriteLine($"A quantidade de palavras na frase é: {resultado}");


            Console.ReadKey();


        }

    }
}
