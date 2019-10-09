using System;
using System.Collections.Generic;
using System.Text;
using TDSTaskDevelopers03.Instrutor;
namespace TDSTaskDevelopers03.Felipe
{
    class CalculoIMC88 : AbstractCalculoIMC
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
    }
}
