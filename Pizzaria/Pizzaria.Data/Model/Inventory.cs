using Pizzaria.Data.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Pizzaria.Data.Model
{
    public class Inventory
    {
        public string Categoria { get; set; }
        public string NomeFornecedor { get; set; }
        public string NumeroDoc { get; set; }
        public string NomeProduto { get; set; }
        public double Valor { get; set; }
        public string Observacao { get; set; }

        public void PopulateDropDown(DropDownList DropDownListCategoria)
        {
            Dictionary<int, string> listCategoria = new Dictionary<int, string>();
            listCategoria.Add(0, "-- Selecione uma categoria");
            listCategoria.Add(1, "Massa");
            listCategoria.Add(2, "Recheio");
            listCategoria.Add(3, "Bebida");
            listCategoria.Add(4, "Ingrediente");
            listCategoria.Add(5, "Outro");

            DropDownListCategoria.DataSource = listCategoria;
            DropDownListCategoria.DataTextField = "Value";
            DropDownListCategoria.DataValueField = "Key";
            DropDownListCategoria.DataBind();
        }
        public void AddIventoryItem()
        {
            string connectionString = WebConfigurationManager.AppSettings["ConnectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(Resources.Resource.AddOnInventory, connection);
                command.Parameters.AddWithValue("@Categoria", Categoria);
                command.Parameters.AddWithValue("@NomeFornecedor", NomeFornecedor);
                command.Parameters.AddWithValue("@NumeroDoc", NumeroDoc);
                command.Parameters.AddWithValue("@NomeProduto", NomeProduto);
                command.Parameters.AddWithValue("@Valor", Valor);
                command.Parameters.AddWithValue("@Observacao", Observacao);
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
        public DataTable GetItemByName(string categoria, string nome)
        {
            string connectionString = WebConfigurationManager.AppSettings["ConnectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(Resources.Resource.GetItemByName, connection);
                command.Parameters.AddWithValue("@categoria", categoria);
                command.Parameters.AddWithValue("@nome", nome);

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
        public void RemoveItem(string NomeFornecedor, string NumDoc, string NomeProduto)
        {
            string connectionString = WebConfigurationManager.AppSettings["ConnectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(Resources.Resource.RemoveItem, connection);
                command.Parameters.AddWithValue("@NomeFornecedor", NomeFornecedor);
                command.Parameters.AddWithValue("@NumeroDoc", NumDoc);
                command.Parameters.AddWithValue("@NomeProduto", NomeProduto);

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