using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pizzaria.Data.Model;
using System.Data;
using System.Threading;

namespace Pizzarias
{
    public partial class Order : System.Web.UI.Page
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
                        #region Populate dropdowns
                        Pizzaria.Data.Model.Order or = new Pizzaria.Data.Model.Order();
                        or.PopulateDropDowns(DropDownListSabor1, DropDownListQuant1);
                        or.PopulateDropDowns(DropDownListSabor2, DropDownListQuant2);
                        or.PopulateDropDowns(DropDownListSabor3, DropDownListQuant3);
                        or.PopulateDropDowns(DropDownListSabor4, DropDownListQuant4);
                        or.PopulateDropDowns(DropDownListSabor5, DropDownListQuant5);
                        or.PopulateDropDowns(DropDownListSabor6, DropDownListQuant6);
                        or.PopulateDropDowns(DropDownListSabor7, DropDownListQuant7);
                        or.PopulateDropDowns(DropDownListSabor8, DropDownListQuant8);
                        #endregion

                        Customer cst = new Customer();
                        DataTable dt = new DataTable();

                        if (Request.QueryString["id"] != null)
                        {
                            dt = cst.GetCustomerByID(Int32.Parse(Request.QueryString["id"]));

                            lblNome.Text = dt.Rows[0].ItemArray[1].ToString();
                            lblTel.Text = dt.Rows[0].ItemArray[2].ToString();
                            lblBarr.Text = dt.Rows[0].ItemArray[3].ToString();
                            lblEnd.Text = dt.Rows[0].ItemArray[4].ToString();
                            lblNum.Text = dt.Rows[0].ItemArray[5].ToString();
                            lblComp.Text = dt.Rows[0].ItemArray[6].ToString();
                        }
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
            Pizzaria.Data.Model.Order or = new Pizzaria.Data.Model.Order();

            if (Request.QueryString["id"] != null && Request.QueryString["id"] != "" && lblNome.Text != "" && lblTel.Text != "")
            {
                or.ID = Request.QueryString["id"];
                or.Cliente = lblNome.Text;
                or.Telefone = lblTel.Text;
                or.Pedido = "";
            }
            else 
            {
                or.ID = "0";
                or.Cliente = "Anonimo";
                or.Telefone = "000000000000";
                or.Pedido = "";
            }

            int val = 0;

            if (DropDownListSabor1.SelectedIndex > 0 && DropDownListQuant1.SelectedIndex > 0)
            {
                or.Pedido = DropDownListSabor1.SelectedItem.Text + " Quant. " + DropDownListQuant1.SelectedItem.Text;
                or.AddOrder();
                val++;
            }

            if (DropDownListSabor2.SelectedIndex > 0 && DropDownListQuant2.SelectedIndex > 0)
            {
                or.Pedido = DropDownListSabor2.SelectedItem.Text + " Quant. " + DropDownListQuant2.SelectedItem.Text;
                or.AddOrder();
                val++;
            }

            if (DropDownListSabor3.SelectedIndex > 0 && DropDownListQuant3.SelectedIndex > 0)
            {
                or.Pedido = DropDownListSabor3.SelectedItem.Text + " Quant. " + DropDownListQuant3.SelectedItem.Text;
                or.AddOrder();
                val++;
            }

            if (DropDownListSabor4.SelectedIndex > 0 && DropDownListQuant4.SelectedIndex > 0)
            {
                or.Pedido = DropDownListSabor4.SelectedItem.Text + " Quant. " + DropDownListQuant4.SelectedItem.Text;
                or.AddOrder();
                val++;
            }

            if (DropDownListSabor5.SelectedIndex > 0 && DropDownListQuant5.SelectedIndex > 0)
            {
                or.Pedido = DropDownListSabor5.SelectedItem.Text + " Quant. " + DropDownListQuant5.SelectedItem.Text;
                or.AddOrder();
                val++;
            }

            if (DropDownListSabor6.SelectedIndex > 0 && DropDownListQuant6.SelectedIndex > 0)
            {
                or.Pedido = DropDownListSabor6.SelectedItem.Text + " Quant. " + DropDownListQuant6.SelectedItem.Text;
                or.AddOrder();
                val++;
            }

            if (DropDownListSabor7.SelectedIndex > 0 && DropDownListQuant7.SelectedIndex > 0)
            {
                or.Pedido = DropDownListSabor7.SelectedItem.Text + " Quant. " + DropDownListQuant7.SelectedItem.Text;
                or.AddOrder();
                val++;
            }

            if (DropDownListSabor8.SelectedIndex > 0 && DropDownListQuant8.SelectedIndex > 0)
            {
                or.Pedido = DropDownListSabor8.SelectedItem.Text + " Quant. " + DropDownListQuant8.SelectedItem.Text;
                or.AddOrder();
                val++;
            }

            if (val == 0)
                lblStatus.Text = "Selecione um sabor, e uma quantidade !";

            #region Reset dropdowns
            or.PopulateDropDowns(DropDownListSabor1, DropDownListQuant1);
            or.PopulateDropDowns(DropDownListSabor2, DropDownListQuant2);
            or.PopulateDropDowns(DropDownListSabor3, DropDownListQuant3);
            or.PopulateDropDowns(DropDownListSabor4, DropDownListQuant4);
            or.PopulateDropDowns(DropDownListSabor5, DropDownListQuant5);
            or.PopulateDropDowns(DropDownListSabor6, DropDownListQuant6);
            or.PopulateDropDowns(DropDownListSabor7, DropDownListQuant7);
            or.PopulateDropDowns(DropDownListSabor8, DropDownListQuant8);
            lblNome.Text = "";
            lblTel.Text = "";
            lblBarr.Text = "";
            lblEnd.Text = "";
            lblNum.Text = "";
            lblComp.Text = "";
            lblStatus.Text = "";
            #endregion

        }
    }
}