using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApi.Entidades
{
    internal class VerificacaoCliente
    {
        public string Cliente()
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=10.41.102.8,49907;Initial Catalog=ORQUESTRA_381_FLUXOS_RAFA;User ID=rafael.wille;pwd=n1010";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand objCollect = new SqlCommand("select cliente from [ORQUESTRA_381_DEV].[dbo].[wVFlow_Form_Execute_TimeSheet] where cliente = 'SouthSide'", cnn);
            SqlDataReader reader = objCollect.ExecuteReader();

            reader.Read();
            string clientes = reader.GetString(0);

            cnn.Close();
            reader.Close();
            return clientes;
        }

        public string Projeto()
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=10.41.102.8,49907;Initial Catalog=ORQUESTRA_381_FLUXOS_RAFA;User ID=rafael.wille;pwd=n1010";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand objVerif = new SqlCommand("select * from [ORQUESTRA_381_DEV].[dbo].[wVFlow_Form_Execute_TimeSheet] where CodFlowExecute = 1509", cnn);
            SqlDataReader reader = objVerif.ExecuteReader();
            reader.Read();
            string projeto = reader.GetString(4);
            reader.Close();
            cnn.Close();
            return projeto;
        }

        public string Colaborador()
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=10.41.102.8,49907;Initial Catalog=ORQUESTRA_381_FLUXOS_RAFA;User ID=rafael.wille;pwd=n1010";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand objVerif = new SqlCommand("select * from [ORQUESTRA_381_DEV].[dbo].[wVFlow_Form_Execute_TimeSheet] where CodFlowExecute = 1509", cnn);
            SqlDataReader reader = objVerif.ExecuteReader();
            reader.Read();
            string colaborador = reader.GetString(2);
            reader.Close();
            cnn.Close();
            return colaborador;
        }
    } // link de criar cliente http://projetos.gateware.com.br:8000/intranet/companies/new
}
