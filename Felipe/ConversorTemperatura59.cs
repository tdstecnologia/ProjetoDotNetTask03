using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTaskDevelopers03.Felipe
{
    class ConversorTemperatura59
    {
        public static void ConverterTemperatura()
        {
            Console.WriteLine("Informe a temperatura em Farenheit para conversão:");
            double temperatura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A temperatura convertida é: {0}", ((temperatura - 32) / 1.8));
        }
    }
}
