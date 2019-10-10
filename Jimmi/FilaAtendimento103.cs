using System;
using System.Collections.Generic;
using System.Text;
using TDSTaskDevelopers03.Instrutor;

namespace TDSTaskDevelopers03.Jimmi
{
    public class FilaAtendimento103
    {
        public static void Main(string[] args)
        {

            var jim = new Pessoa() { Cpf = "987.987.888-22", Nome = "Jim" };
            var lucas = new Pessoa() { Cpf = "458.258.963-52", Nome = "lucas" };
            var alice = new Pessoa() { Cpf = "654.312.111-88", Nome = "Alice" };

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(jim);
            pessoas.Add(lucas);
            pessoas.Add(alice);


            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine("Digite p para continuar...");

                Console.ReadLine();

                Console.WriteLine("Nome: ", p.Nome + " Cpf:", p.Cpf );
            }
            Console.WriteLine("Todas as pessoas foram atendidas.");
        }
    }
}
