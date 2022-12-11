using System;
using ConsumindoApi.Entidades;

namespace ConsumindoApi
{
    class Program
    {
        public static void Main(string[] args)
        {
            Conexao f = new Conexao();
            

           Array array_infos = f.PegarDados();

            foreach (var dado in array_infos)
            {
                Console.WriteLine(dado);
                
            }

            VerificacaoCliente v = new VerificacaoCliente();

            object cliente = v.Cliente();
            string projeto = v.Projeto();
            string colaborador = v.Colaborador();
           
            Console.WriteLine("o cliente é o " + cliente);
            Console.WriteLine("o projeto é o " + projeto);
            Console.WriteLine("o colaborador a ser cadastrado é " + colaborador);
            Console.ReadLine();
    

        }
    }
}