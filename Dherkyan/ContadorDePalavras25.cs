using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTaskDevelopers03.Dherkyan
{
    public class ContadorDePalavras25
    {

        public static void Executar()
        {
            string texto = "Sou o melhor no que faço, mas o que eu faço não é o melhor";
            Console.WriteLine("Quantidade Palavras: "+texto.Split(" ").Length);
        }

       
    }
}
