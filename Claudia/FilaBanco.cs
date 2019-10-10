using System;
using System.Collections.Generic;
using System.Text;
using TDSTaskDevelopers03.Instrutor;

namespace TDSTaskDevelopers03.Claudia
{
    class FilaBanco
    {
        public FilaBanco()
        {
            var ana = new Pessoa() { Cpf = "011.111.111-11", Nome = "Ana" };
            var bob = new Pessoa() { Cpf = "011.222.222-22", Nome = "Bob" };
            var anaAlice = new Pessoa() { Cpf = "011.111.111-11", Nome = "Ana Alice" };
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(ana);
            pessoas.Add(bob);
            pessoas.Add(anaAlice);

            while (Console.ReadLine() == "p")
            {
                if (pessoas.Count >= 1)
                {
                    Console.WriteLine(pessoas[0].Cpf + " - " + pessoas[0].Nome);
                    pessoas.Remove(pessoas[0]);

                } else
                {
                    Console.WriteLine("Todas pessoas foram atendidas");
                }
            }
        }
    }
}
