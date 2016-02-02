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
    public partial class CustomerSearch : System.Web.UI.Page
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
        protected void btPesquisa_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;

            Customer cst = new Customer();
            GridView1.DataSource = cst.GetCustomerByName(txtPesquisa.Text);
            GridView1.DataBind();
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;

            string id = grdrow.Cells[0].Text;

            Page.ClientScript.RegisterStartupScript(GetType(), "pop", "EditCustomer('"+id+"');", true);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;

            string id = grdrow.Cells[0].Text;

            Response.Redirect("Order.aspx?id=" + id);
        }
    }
}