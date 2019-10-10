using System;
using System.Collections.Generic;
using System.Text;
using TDSTaskDevelopers03.Instrutor;


namespace TDSTaskDevelopers03.Carlos
{
    public class CalculoIMC : AbstractCalculoIMC, IClassificacaoIMC
    {
        public override double CalcularIMC()


        {
            double peso = 150.2;
            string mensagem = "Peso" + peso;
            double altura = 1.82;
            mensagem = "Altura" + altura;

            double resultado = (peso / (altura * altura));


            return resultado;

        }

        public void ClassificarIMC(double imc)
        {
            string mensagem = "Classificar IMC: " + imc;

            Console.WriteLine(mensagem);

            if (imc < 18.5)
            {
                Console.WriteLine("Magreza");

            }
            else if (imc > 18.5 && imc < 24.9)
            {
                Console.WriteLine("Normal");
            }
            else if (imc > 25.0 && imc < 29.9)
            {
                Console.WriteLine("Sobre Peso");
            }
            else if (imc > 30.0 && imc < 39.9)
            {
                Console.WriteLine("Obesidade");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade Grave");
            }



        }
    }
}
