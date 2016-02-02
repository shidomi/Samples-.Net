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
    public class Order
    {
        public string ID { get; set; }
        public string Cliente { get; set; }
        public string Telefone { get; set; }
        public string Pedido { get; set; }

        public void PopulateDropDowns(DropDownList DropDownListSabor, DropDownList DropDownListQua)
        {
            Dictionary<int, string> listSabor = new Dictionary<int, string>();
            listSabor.Add(0, "-- Selecione o sabor");
            listSabor.Add(1, "Mussarela");
            listSabor.Add(2, "Calabresa");
            listSabor.Add(3, "Palmito");
            listSabor.Add(4, "Portuguesa");
            listSabor.Add(5, "Peperone");
            listSabor.Add(6, "Brocolis");
            listSabor.Add(7, "Atum");
            listSabor.Add(8, "Baiana");

            Dictionary<int, string> listQua = new Dictionary<int, string>();
            listQua.Add(0, "Qt.");
            listQua.Add(1, "0/5");
            listQua.Add(2, "1");
            listQua.Add(3, "2");
            listQua.Add(4, "3");
            listQua.Add(5, "4");
            listQua.Add(6, "5");
            listQua.Add(7, "6");
            listQua.Add(8, "7");
            listQua.Add(9, "8");
            listQua.Add(10, "9");
            listQua.Add(11, "10");

            DropDownListSabor.DataSource = listSabor;
            DropDownListSabor.DataTextField = "Value";
            DropDownListSabor.DataValueField = "Key";
            DropDownListSabor.DataBind();

            DropDownListQua.DataSource = listQua;
            DropDownListQua.DataTextField = "Value";
            DropDownListQua.DataValueField = "Key";
            DropDownListQua.DataBind();
        }

        public void AddOrder() 
        {
            string connectionString = WebConfigurationManager.AppSettings["ConnectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(Resources.Resource.InsertOrder, connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Cliente", Cliente);
                command.Parameters.AddWithValue("@Telefone", Telefone);
                command.Parameters.AddWithValue("@Pedido", Pedido);
                command.Parameters.AddWithValue("@DataPedido", DateTime.Now);

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