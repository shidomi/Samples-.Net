using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizzaria
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("adm") && txtSenha.Text.Equals("adm"))
            {
                Session["UserIsValid"] = true;
                Response.Redirect("Home_Blank.aspx");
            }
            else
            {
                lblMsg.Text = "Usuário ou senha inválidos";
            }
        }
    }
}