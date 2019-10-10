using System;
using System.Collections.Generic;
using System.Text;
using TDSTaskDevelopers03.Instrutor;

namespace TDSTaskDevelopers03.Wander
{
    class FilaBancoWander : Pessoa
    {
        public static void FilaBanco()
        {
            var ana = new Pessoa() { Cpf = "011.111.111-11", Nome = "Ana" };
            var carla = new Pessoa() { Cpf = "888.111.111-11", Nome = "Carla" };
            var pedro = new Pessoa() { Cpf = "999.111.111-11", Nome = "Pedro" };
            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(ana);
            lista.Add(carla);
            lista.Add(pedro);
            /*
            foreach (Pessoa p in lista)
            {
                Console.WriteLine("Digite p para atender a próxima pessoa");
                string letra = Console.ReadLine();
                if (letra == "p")
                {
                    Console.WriteLine(p.Nome + " " + p.Cpf);
                    lista.Remove(new Pessoa() { Cpf = p.Cpf, Nome = p.Nome });
                }
            }
            */


            for (int i = 0; i < lista.Count; i--)
            {
                Console.WriteLine("Digite p para atender a próxima pessoa");
                string letra = Console.ReadLine();
                if (letra == "p")
                {
                    Pessoa p = lista[0];
                    Console.WriteLine(p.Nome + " " + p.Cpf);
                    lista.Remove(new Pessoa() { Cpf = p.Cpf, Nome = p.Nome });
                }
                if (lista.Count == 0)
                {
                    Console.WriteLine("A Fila acabou");
                    break;
                }
            }
        }
    }
}
