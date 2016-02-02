using Pizzaria.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizzaria
{
    public partial class RemoveItem : System.Web.UI.Page
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

                    lblNf.Text = Request.QueryString["nf"];
                    lblNd.Text = Request.QueryString["nd"];
                    lblNp.Text = Request.QueryString["np"];
                    lblQt.Text = Request.QueryString["qt"];
                }
            }
            else
                Response.Redirect("Login.aspx");
        }

        protected void btGravar_Click(object sender, EventArgs e)
        {
            Inventory iv = new Inventory();
            if (lblNf.Text != "" && lblNd.Text != "" && lblNp.Text != "" && lblQt.Text != "")
                for (int i = 0; i < Int32.Parse(txtQt.Text); i++)
                    iv.RemoveItem(lblNf.Text, lblNd.Text, lblNp.Text);

            Page.ClientScript.RegisterStartupScript(GetType(), "pop", "window.close();", true);
        }
    }
}