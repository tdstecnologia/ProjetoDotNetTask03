using System;
using TDSTaskDevelopers03.Carlos;


namespace TDSTaskDevelopers03
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoIMC calculoIMC = new CalculoIMC();

            double  imc = calculoIMC.CalcularIMC();
            calculoIMC.ClassificarIMC(imc);
        }
    }
}
