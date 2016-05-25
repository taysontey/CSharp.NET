using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Estoque.Entity.Entities;

namespace Estoque.Site.Shared
{
    public partial class AdminTemplate : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Funcionario f = (Funcionario)Session["funcionario"];
             lblFuncionario.Text = string.Format("{0}", f.Login);
        }
    }
}