using System;
using System.Collections.Generic;
using System.Text;
using TDSTaskDevelopers03.Instrutor;

namespace TDSTaskDevelopers03.FelipeRyan
{
    public class CalculoIMC : AbstractCalculoIMC
    {
        public override double CalcularIMC()
        {
            double peso = 80;
            double alt = 1.70;
     
            double imc = peso / (alt * alt);
            Console.WriteLine("IMC: " + imc);
            return imc;

        }

    }
}
