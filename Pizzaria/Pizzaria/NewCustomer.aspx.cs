using Pizzaria.Data.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizzaria
{
    public partial class NewCustomer : System.Web.UI.Page
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

                    txtTel.Text = Request.QueryString["nmbr"];
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

            DataTable dt = new DataTable();
            dt = cst.GetCustomerByNumber(txtTel.Text);

            if (dt != null)
            {
                if (dt.Rows.Count > 0) 
                {
                    Session["NewCustomerHandler"] = dt.Rows[0].ItemArray[0].ToString();
                }
            }

            Page.ClientScript.RegisterStartupScript(this.GetType(), "CloseScript", "window.close()", true);
        }
    }
}