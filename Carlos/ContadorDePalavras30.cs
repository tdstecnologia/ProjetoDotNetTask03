using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTaskDevelopers03.Carlos
{
    class ContadorDePalavras30
    {

        static string texto = "Sou o melhor no que faço, mas o que eu faço não é o melhor";

        public int ContarNumeroPalavras(string frase)
        {
            string[] palavras = frase.Split(' ');
            return palavras.Length;
        }


        public static void Main(String[] args)
        {
           
            ContadorDePalavras30 classe = new ContadorDePalavras30();
            int resultado = 0;

            resultado = classe.ContarNumeroPalavras(texto);

            Console.WriteLine($"Resultado: {resultado}");

            Console.ReadKey();

        }






    }
}
