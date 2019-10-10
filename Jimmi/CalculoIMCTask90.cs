using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTaskDevelopers03.Jimmi
{
    public abstract class CalculoIMCTask90 : Instrutor.AbstractCalculoIMC , Instrutor.IClassificacaoIMC
    {

        public double peso { get; set; }
        public double altura { get; set; }

        public override double CalcularIMC()
        {
            return peso / altura * altura;
        }

        
        public void ClassificarIMC(double imc)
            {
             
        /*
        *  CLASSIFICAÇÃO - IMC
           MENOR QUE 18,5 MAGREZA
           ENTRE 18,5 E 24,9 NORMAL
           ENTRE 25,0 E 29,9 SOBREPESO
           ENTRE 30,0 E 39,9 OBESIDADE
           MAIOR QUE 40,0 OBESIDADE GRAVE
        */
           if (imc < 18.5)
            {
                Console.WriteLine("Magreza");
            }
           else 
            if (imc <=18.5 && imc<=24.9 )
            { 
                Console.WriteLine("Normal");
            }
           else
            if (imc <= 25.0 && imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
           else
            if (imc <= 30.0 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade");
            }
            else
            if (imc > 40.0)
            {
                Console.WriteLine("Obesidade Grave");
            }

        }
    }
}
