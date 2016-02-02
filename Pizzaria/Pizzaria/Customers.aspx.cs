using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pizzaria.Data.Model;
using System.Threading;

namespace Pizzaria
{
    public partial class Customers : System.Web.UI.Page
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
                    if (!Page.IsPostBack)
                    {

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
            Customer cst = new Customer();

            cst.Nome = txtNome.Text;
            cst.Telefone = txtTel.Text;
            cst.Endereco = txtEnd.Text;
            cst.Bairro = txtBairro.Text;
            cst.Numero = int.Parse(txtNum.Text);
            cst.Complemento = txtComp.Text;
            cst.Obs = txtObs.Text;

            cst.AddCustomer();

            txtNome.Text = "";
            txtTel.Text = "";
            txtEnd.Text = "";
            txtBairro.Text = "";
            txtNum.Text = "";
            txtComp.Text = "";
            txtObs.Text = "";
            lblStatus.Text = "Cadastrado com sucesso !";
        }
    }
}