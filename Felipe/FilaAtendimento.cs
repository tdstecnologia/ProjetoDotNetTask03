using System;
using System.Collections.Generic;
using System.Text;
using TDSTaskDevelopers03.Instrutor;

namespace TDSTaskDevelopers03.Felipe
{
    class FilaAtendimento
    {
        public void executar()
        {
            chamaProximoFila();
        }

        public void chamaProximoFila()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            listaPessoas.Add(new Pessoa() { Cpf = "011.111.111-11", Nome = "Ana" });
            listaPessoas.Add(new Pessoa() { Cpf = "011.111.188-11", Nome = "Jones" });
            listaPessoas.Add(new Pessoa() { Cpf = "011.551.188-11", Nome = "Callori" });

            Console.WriteLine("digite p para chamar o próximo da fila: ");
            do
            {
                string digito = Console.ReadLine();
                if (listaPessoas.Count > 0 &&  (digito.ToUpper()).Equals("P"))
                {
                    Pessoa pessoa = listaPessoas[0];
                    Console.WriteLine("Próximo da fila:{0} - {1}", pessoa.Nome, pessoa.Cpf);
                    listaPessoas.Remove(pessoa);
                }

            } while (listaPessoas.Count > 0);

            Console.WriteLine("Todas pessoas foram atendidas");
        }
    }
}
