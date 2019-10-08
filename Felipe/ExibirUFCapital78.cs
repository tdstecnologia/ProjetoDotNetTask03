using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTaskDevelopers03.Felipe
{
    class ExibirUFCapital78
    {
        public static void ExibirUFCapital()
        {
            try
            {
                Console.WriteLine("Informe a sigla da sua UF:");
                string uf = Console.ReadLine();

                if (uf.Length > 2)
                {
                    throw new Exception("A UF deve ter somente 2 dígitos");
                }

                Console.WriteLine(RetornaCapitalPorUF(uf.ToUpper()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Formato de UF inválido, consulte o administrador do sistema. Detalhes do erro : {0}", e.Message);
            }
        }

        public static string RetornaCapitalPorUF(string uf)
        {
            switch (uf)
            {
                case "AC":
                    return "AC - Acre - Rio Branco Norte";
                case "AL":
                    return "AL - Alagoas - Maceió Nordeste";
                case "AP":
                    return "AP - Amapá - Macapá Norte";
                case "AM":
                    return "AM - Amazonas - Manaus Norte";
                case "BA":
                    return "BA - Bahia - Salvador Nordeste";
                case "CE":
                    return "CE - Ceará - Fortaleza Nordeste";
                case "DF":
                    return "DF - Distrito Federal - Brasília Centro - Oeste";
                case "MT":
                    return "MT - Mato Grosso - Cuiabá Centro - Oeste";
                case "MS":
                    return "MS - Mato Grosso do Sul - Campo Grande Centro - Oeste";
              
                default:
                    return ("Estado não encontrado");
             }
        }

    }  
}
