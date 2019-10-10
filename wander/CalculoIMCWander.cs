using System;
using System.Collections.Generic;
using System.Text;
using TDSTaskDevelopers03.Instrutor;

namespace TDSTaskDevelopers03.Wander
{
    class CalculoIMCWander : AbstractCalculoIMC, IClassificacaoIMC
    {

        public override double CalcularIMC()
        {
            
            Console.WriteLine("Digite seu peso temperatura");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura");
            double altura = double.Parse(Console.ReadLine());
            double IMC = peso/(altura * altura);            
            return IMC;
        }

        public void ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                Console.WriteLine("MAGREZA");
                return;
            } else  if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("NORMAL");
                return;
            } else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("SOBREPESO");
                return;
            } else  if (imc >= 30 && imc <= 39.9)
            {
                Console.WriteLine("OBESIDADE");
                return;
            } else if (imc >= 40)
            {
                Console.WriteLine("OBESIDADE GRAVE");
                return;
            }
        }
    }
}
