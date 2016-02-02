using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizzaria
{
    public partial class FoundCustomer : System.Web.UI.Page
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

                    lblTel.Text = Request.QueryString["tel"];
                    lblNome.Text = Request.QueryString["nome"];
                    lblEnd.Text = Request.QueryString["end"];
                    lblBairro.Text = Request.QueryString["barr"];
                    lblNum.Text = Request.QueryString["num"];
                    lblComp.Text = Request.QueryString["comp"];
                    lblObs.Text = Request.QueryString["obs"];
                }
            }
            else
                Response.Redirect("Login.aspx");
        }

        protected void btGravar_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["cst"] != null)
                Session["FoundCustomerHandler"] = Request.QueryString["cst"];

            Page.ClientScript.RegisterStartupScript(GetType(), "close", "window.close();", true);
        }
    }
}