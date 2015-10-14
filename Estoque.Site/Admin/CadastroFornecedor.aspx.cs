using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Estoque.DAL.Entity;
using Estoque.DAL.Persistence;

namespace Estoque.Site.Admin
{
    public partial class CadastroFornecedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor f = new Fornecedor();
                f.Nome = txtNome.Text;

                FornecedorDal d = new FornecedorDal();
                d.Insert(f);

                lblMensagem.Text = "Fornecedor " + f.Nome + ", cadastrado com sucesso.";

                txtNome.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}