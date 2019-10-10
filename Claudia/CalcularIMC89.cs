using System;
using System.Collections.Generic;
using System.Text;
using TDSTaskDevelopers03.Instrutor;

namespace TDSTaskDevelopers03.Claudia
{
    class CalcularIMC89 : AbstractCalculoIMC, IClassificacaoIMC

    {

        public CalcularIMC89()
        {
            double imc;

            imc = CalcularIMC(); //
            Console.WriteLine("Seu IMC é" + imc);
            ClassificarIMC(imc);
        }


        public override double CalcularIMC()
        {
            Console.WriteLine("Digite o peso:");
            Double peso = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura:");
            Double altura = Double.Parse(Console.ReadLine());
            altura = altura * altura;
            Console.WriteLine("altura calculada:" + altura);
            return peso / altura;
        }

        public void ClassificarIMC(double imc)
        {
            /*CLASSIFICAÇÃO - IMC
            MENOR QUE 18,5 MAGREZA
            ENTRE 18,5 E 24,9 NORMAL
            ENTRE 25,0 E 29,9 SOBREPESO
            ENTRE 30,0 E 39,9 OBESIDADE
            MAIOR QUE 40,0 OBESIDADE GRAVE*/

            if (imc < 18.5)
            {
                Console.WriteLine("MAGREZA");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("NORMAL");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("SOBREPESO");
            }
            else if (imc < 39.9)
            {
                Console.WriteLine("OBESIDADE");
            } else
            {
                Console.WriteLine("OBESIDADE GRAVE");
            }
        }   
    }
            
    
}
