using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Estoque.DAL.Entity;
using Estoque.DAL.Persistence;
using System.Web.Security;

namespace Estoque.Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDal d = new FuncionarioDal();

                Funcionario f = d.Authenticate(txtLogin.Text, txtSenha.Text);

                if(f != null)
                {
                    FormsAuthentication.SetAuthCookie(f.Login, checkLogin.Checked);
                    Session.Add("Funcionario", f);
                    Response.Redirect("/Admin/Default.aspx");
                }
                else
                {
                    throw new Exception("Acesso Negado, Tente novamente.");
                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}