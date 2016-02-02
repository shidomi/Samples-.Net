using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MvcPartialView.Models
{
    [Serializable]
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }

        public bool addProduto()
        {
            var connection = "Data Source=RAFAEL-PC;Initial Catalog=Test;Integrated Security=True";
            var procedure = "AddProduct";
            var sucessful = false;

            using (SqlConnection cnn = new SqlConnection(connection))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(procedure, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Nome", this.Nome);
                    cmd.Parameters.Add("@Quantidade", this.Quantidade);
                    cmd.Parameters.Add("@Descricao", this.Descricao);
                    cmd.Parameters.Add("@Categoria", this.Categoria);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        sucessful = true;
                    }
                    catch (Exception)
                    { }
                }
            }

            return sucessful;
        }
    }

    [Serializable]
    [XmlRoot("ProdutoCollection")]
    public class ProdutoCollection : List<Produto>
    {
        public static ProdutoCollection GetAllProducts()
        {
            var connection = "Data Source=RAFAEL-PC;Initial Catalog=Test;Integrated Security=True";
            var procedure = "GetAllProducts";

            using (SqlConnection cnn = new SqlConnection(connection))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(procedure, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(ProdutoCollection));
                        return (ProdutoCollection)ser.Deserialize(cmd.ExecuteXmlReader());
                    }
                    catch (Exception)
                    { }
                }
            }
            return null;
        }
    }
}