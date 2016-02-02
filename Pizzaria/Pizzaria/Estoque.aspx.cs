using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pizzaria.Data.Model;
using System.Globalization;
using System.Xml;
using System.Threading;

namespace Pizzaria
{
    public partial class Estoque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserIsValid"] != null)
            {
                if (!(bool)Session["UserIsValid"])
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    txtDocumento.Attributes.Add("onKeypress", "return validaTecla(this, event)");
                    txtQuantidade.Attributes.Add("onKeypress", "return validaTecla(this, event)");
                    txtValor.Attributes.Add("onKeypress", "return validaTecla(this, event)");

                    if (!IsPostBack)
                    {
                        Inventory iv = new Inventory();
                        iv.PopulateDropDown(drpCategoria);
                    }

                    if (Session["FoundCustomerHandler"] != null)
                    {
                        string param = Session["FoundCustomerHandler"].ToString();
                        Session["FoundCustomerHandler"] = null;
                        Thread.Sleep(500);
                        Response.Redirect("Order.aspx?id=" + param);
                    }

                    if (Session["NewCustomerHandler"] != null)
                    {
                        string param = Session["NewCustomerHandler"].ToString();
                        Session["NewCustomerHandler"] = null;
                        Thread.Sleep(500);
                        Response.Redirect("Order.aspx?id=" + param);
                    }
                }
            }
            else
                Response.Redirect("Login.aspx");
        }

        protected void btGravar_Click(object sender, EventArgs e)
        {
            if (!drpCategoria.SelectedIndex.Equals(0))
            {
                Inventory iv = new Inventory();
                iv.Categoria = drpCategoria.SelectedItem.Text;
                iv.NomeFornecedor = txtFornecedor.Text;
                iv.NumeroDoc = txtDocumento.Text;
                iv.NomeProduto = drpItem.SelectedItem.Text;
                iv.Valor = double.Parse(txtValor.Text, CultureInfo.InvariantCulture);
                iv.Observacao = txtObs.Text;

                for (int i = 0; i < Int32.Parse(txtQuantidade.Text); i++)
                    iv.AddIventoryItem();

                //Reset screen
                iv.PopulateDropDown(drpCategoria);
                lblCategoria.Text = "";
                txtFornecedor.Text = "";
                txtDocumento.Text = "";
                txtValor.Text = "";
                txtQuantidade.Text = "";
                txtObs.Text = "";

                lblStatus.Text = "Item cadastrado com sucesso !";
            }
            else
            {
                lblCategoria.Text = "Selecione uma categoria";
            }
        }

        protected void drpCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            string path = HttpContext.Current.Server.MapPath("~/App_Data/InventorySchema.xml");
            doc.Load(path);

            string grupo = "";
            switch (drpCategoria.SelectedItem.Text)
            {
                case "Massa":
                    grupo = "Massa";
                    break;

                case "Recheio":
                    grupo = "Recheio";
                    break;

                case "Bebida":
                    grupo = "Bebida";
                    break;

                case "Ingrediente":
                    grupo = "Ingrediente";
                    break;

                case "Outro":
                    grupo = "Outro";
                    break;
            }

            if (!String.IsNullOrEmpty(grupo))
            {
                XmlNodeList elemList = doc.GetElementsByTagName(grupo);

                drpItem.Items.Clear();
                for (int i = 0; i < elemList.Count; i++)
                {
                    drpItem.Items.Add(elemList[i].InnerXml);
                }
            }
        }
    }
}