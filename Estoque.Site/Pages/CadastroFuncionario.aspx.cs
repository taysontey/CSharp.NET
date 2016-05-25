using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Estoque.Entity.Entities;
using Estoque.DAL.Persistence;

namespace Estoque.Site.Pages
{
    public partial class CadastroFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSenha.Text.Equals(txtConfirmSenha.Text))
                {
                    Funcionario f = new Funcionario();
                    f.Login = txtLogin.Text;
                    f.Senha = txtSenha.Text;
                    f.Nome = txtNome.Text;

                    FuncionarioDal d = new FuncionarioDal();
                    d.Insert(f);

                    lblMensagem.Text = "Funcionário " + f.Nome + ", cadastrado com sucesso.";

                    txtLogin.Text = string.Empty;
                    txtNome.Text = string.Empty;
                }
                else
                {
                    throw new Exception("As senhas não conferem, tente novamente.");
                }
                
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }

        }
    }
}