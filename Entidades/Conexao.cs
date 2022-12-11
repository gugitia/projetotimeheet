using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApi.Entidades
{
    internal class Conexao
    {
        private void ConexaoDb()
        {
            try
            {
                string connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=10.41.102.8,49907;Initial Catalog=ORQUESTRA_381_FLUXOS_RAFA;User ID=rafael.wille;pwd=n1010";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                Console.WriteLine("Conexão Sucedida");
                
              //  Console.WriteLine(dados);

                //  Console.WriteLine(codform + " é o valor");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
        public object[] PegarDados()
        {
             ConexaoDb();
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=10.41.102.8,49907;Initial Catalog=ORQUESTRA_381_FLUXOS_RAFA;User ID=rafael.wille;pwd=n1010";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand objVerif = new SqlCommand("select * from [ORQUESTRA_381_DEV].[dbo].[wVFlow_Form_Execute_TimeSheet] where CodFlowExecute = 1509", cnn);
            SqlDataReader reader = objVerif.ExecuteReader();
            Object[] array_infos = new Object[reader.FieldCount];

            while (reader.Read())
            {
                reader.GetValues(array_infos);
            }

           

            cnn.Close();
            reader.Close();

            return array_infos;
            
        }

       
    }
}
