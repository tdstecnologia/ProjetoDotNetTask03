using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTaskDevelopers03.Carlos
{
     public class Pessoa
    {
        public static void Main(string[] args)
        {
            var ana = new Pessoa() { Cpf = "011.111.111-11", Nome = "Ana" };
            var bob = new Pessoa() { Cpf = "011.111.111-11", Nome = "Ana" };
            
            Console.WriteLine("Iguais: " + ana.GetHashCode());
        }
        
        public string Cpf { get; set; }
        public string Nome { get; set; }
        
        public override bool Equals(object obj)
        {
            return obj is Pessoa pessoa &&
                   Nome == pessoa.Nome;
        }
        
        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }

    }
}
