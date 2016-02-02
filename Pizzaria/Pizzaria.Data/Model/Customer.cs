using Pizzaria.Data.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Pizzaria.Data.Model
{
    public class Customer
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Obs { get; set; }

        public DataTable GetCustomer() 
        {
            string connectionString = WebConfigurationManager.AppSettings["ConnectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(Resources.Resource.GetCustomer, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    dt.Load(reader);

                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dt.Dispose();
                    connection.Close();
                }

                return null;
            }
        }

        public DataTable GetCustomerByID(int id)
        {
            string connectionString = WebConfigurationManager.AppSettings["ConnectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(Resources.Resource.GetCustomerByID, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    dt.Load(reader);

                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dt.Dispose();
                    connection.Close();
                }

                return null;
            }
        }

        public DataTable GetCustomerByNumber(string nmbr) 
        {
            string connectionString = WebConfigurationManager.AppSettings["ConnectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(Resources.Resource.GetCustomerByNumber, connection);
                command.Parameters.AddWithValue("@nmbr", nmbr);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    dt.Load(reader);

                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dt.Dispose();
                    connection.Close();
                }

                return null;
            }
        }

        public DataTable GetCustomerByName(string name)
        {
            string connectionString = WebConfigurationManager.AppSettings["ConnectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(Resources.Resource.GetCustomerByName, connection);
                command.Parameters.AddWithValue("@name ", name);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    dt.Load(reader);

                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dt.Dispose();
                    connection.Close();
                }

                return null;
            }
        }

        public void AddCustomer() 
        {
            string connectionString = WebConfigurationManager.AppSettings["ConnectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(Resources.Resource.InsertCustomer, connection);
                command.Parameters.AddWithValue("@Nome", Nome);
                command.Parameters.AddWithValue("@Telefone", Telefone);
                command.Parameters.AddWithValue("@Endereco", Endereco);
                command.Parameters.AddWithValue("@Bairro", Bairro);
                command.Parameters.AddWithValue("@Numero", Numero);
                command.Parameters.AddWithValue("@Complemento", Complemento);
                command.Parameters.AddWithValue("@Observacoes", Obs);
                command.Parameters.AddWithValue("@DataCriacao", DateTime.Now);

                try
                {
                    connection.Open();
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dt.Dispose();
                    connection.Close();
                }
            }
        }

        public void EditCustomer(string id,  string tel, string nome, string end, string barr, string num, string comp, string obs)
        {
            string connectionString = WebConfigurationManager.AppSettings["ConnectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(Resources.Resource.EditCustomer, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@tel", tel);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@end", end);
                command.Parameters.AddWithValue("@barr", barr);
                command.Parameters.AddWithValue("@num", num);
                command.Parameters.AddWithValue("@comp", comp);
                command.Parameters.AddWithValue("@obs", obs);

                try
                {
                    connection.Open();
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dt.Dispose();
                    connection.Close();
                }
            }
        }
    }
}