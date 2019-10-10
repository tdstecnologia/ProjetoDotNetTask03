using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTaskDevelopers03.Jimmi

{
    class ClasseCalculaAreaCirculo
    {
        public double area;

        public double CalculoArea(double raio)
        {
            try
            {
                area = 3.14 * (raio * raio);
                return area;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Valor inválido.");
                return 0;
            }
        }
    }
}
