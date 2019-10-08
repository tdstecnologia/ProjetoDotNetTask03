using System;
using System.Collections.Generic;
using System.Text;
using TDSTaskDevelopers03.JoaoPaulo.MinhasExceptions;

namespace TDSTaskDevelopers03.JoaoPaulo
{
    public class ConversorTemperatura
    {
        public double appConversorTemperatura(double temperatura)
        {
            double resultado = (temperatura - 32) / 1.8;
            return resultado;
        }

        public void ValidarTemperatura(double temperatura)
        {
            if (temperatura > 10)
            {
                throw new TemperaturaInvalidaException();
            }
            else
            {
                //Temperatura valida!!
            }
        }


        public ConversorTemperatura() { }
    }
}
