using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTaskDevelopers03.Wander
{
    class ConversorTemperaturaWander
    {
        public static void ConverterTemperatura()
        {
            try
            {
                Console.WriteLine("Digite a temperatura");
                double F = double.Parse(Console.ReadLine());
                double C = 0.0;
                C =((F - 32) / 1.8);
                Console.WriteLine(C);
            }
            catch (FormatException e) {
                Console.WriteLine("Erro no formato" + e.Message);
            }
        }
    }
}
