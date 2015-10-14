using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Estoque.DAL.Entity;
using System.Web.Security;

namespace Estoque.Site.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Funcionario f = (Funcionario)Session["funcionario"];
            lblFuncionario.Text = string.Format("{0}", f.Nome);
            
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Remove("funcionario");
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
}