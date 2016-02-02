using Pizzaria.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Pizzaria
{
    public partial class CustomerEdit : System.Web.UI.Page
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
                        Customer cst = new Customer();
                        DataTable dt = new DataTable();

                        if (Request.QueryString["id"] != null)
                            dt = cst.GetCustomerByID(Int32.Parse(Request.QueryString["id"]));

                        txtNome.Text = dt.Rows[0].ItemArray[1].ToString();
                        txtTel.Text = dt.Rows[0].ItemArray[2].ToString();
                        txtEnd.Text = dt.Rows[0].ItemArray[3].ToString();
                        txtBairro.Text = dt.Rows[0].ItemArray[4].ToString();
                        txtNum.Text = dt.Rows[0].ItemArray[5].ToString();
                        txtComp.Text = dt.Rows[0].ItemArray[6].ToString();
                        txtObs.Text = dt.Rows[0].ItemArray[7].ToString();
                    }
                }
            }
            else
                Response.Redirect("Login.aspx");
        }

        protected void btGravar_Click(object sender, EventArgs e)
        {
            Customer cst = new Customer();

            string id = Request.QueryString["id"];
            string tel = txtTel.Text;
            string nome = txtNome.Text;
            string end = txtEnd.Text;
            string bairro = txtBairro.Text;
            string num = txtNum.Text;
            string comp = txtComp.Text;
            string obs = txtObs.Text;

            cst.EditCustomer(id, tel, nome, end, bairro, num, comp, obs);

            Page.ClientScript.RegisterStartupScript(GetType(), "close", "window.close();", true);
        }
    }
}