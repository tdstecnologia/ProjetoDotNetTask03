using System;
using System.Collections.Generic;
using System.Text;
using TDSTaskDevelopers03.Instrutor;
namespace TDSTaskDevelopers03.Felipe
{
    class CalculoIMC88 : AbstractCalculoIMC,IClassificacaoIMC
    {
        public CalculoIMC88()
        {
        }

        public override double CalcularIMC()
        {
            Console.WriteLine("Informe sua altura: ");
            Double altura = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu peso: ");
            Double peso = Double.Parse(Console.ReadLine());

            return peso/(altura*altura);
        }

        public void ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                Console.WriteLine("MAGREZA");
                return;
            }
            if(imc >=18.5 && imc <= 24.9)
            {
                Console.WriteLine("NORMAL");
                return;
            }
            if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("SOBREPESO");
                return;
            }

            if (imc >= 30 && imc <= 39.9)
            {
                Console.WriteLine("OBESIDADE");
                return;
            }
            if (imc >= 40)
            {
                Console.WriteLine("OBESIDADE GRAVE");
                return;
            }
        }
    }
}
