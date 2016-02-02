using Pizzaria.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizzaria
{
    public partial class EstoqueSearch : System.Web.UI.Page
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

        protected void btPesquisa_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;

            Inventory inv = new Inventory();
            GridView1.DataSource = inv.GetItemByName(drpCategoria.SelectedItem.Text, txtPesquisa.Text);
            GridView1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;
            string NomeFornecedor = grdrow.Cells[0].Text;
            string NumDoc = grdrow.Cells[1].Text;
            string NomeProduto = grdrow.Cells[2].Text;
            string Quantidade = grdrow.Cells[4].Text;

            Page.ClientScript.RegisterStartupScript(GetType(), "pop", "RemoveItem('"+ NomeFornecedor +"', '"+ NumDoc +"', '"+ NomeProduto +"', '"+ Quantidade +"');", true);
        }
    }
}