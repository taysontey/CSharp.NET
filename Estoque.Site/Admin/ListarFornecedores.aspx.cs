using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Estoque.DAL.Persistence;
using Estoque.DAL.Entity;

namespace Estoque.Site.Admin
{
    public partial class ListarFornecedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gridBind();
            }
        }
        protected void gridBind()
        {
            FornecedorDal d = new FornecedorDal();
            gridFornecedor.DataSource = d.FindAll();
            gridFornecedor.DataBind();  
        }

        protected void gridFornecedor_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                FornecedorDal d = new FornecedorDal();
                d.Delete(Convert.ToInt32(gridFornecedor.DataKeys[e.RowIndex].Value.ToString()));

                lblMensagem.Text = "Fornecedor Excluido.";

                gridBind();
            }
            catch (Exception ex)
            {

                lblMensagem.Text = "Erro: ao deletar Fornecedor, o mesmo pode ter produtos ligados a ele. <br/> <br/>" + ex.Message;
            }
            
        }
    }
}