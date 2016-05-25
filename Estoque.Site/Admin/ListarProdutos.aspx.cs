using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Estoque.DAL.Persistence;
using Estoque.Entity.Entities;

namespace Estoque.Site.Admin
{
    public partial class ListarProdutos : System.Web.UI.Page
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
            ProdutoDal d = new ProdutoDal();
            gridProduto.DataSource = d.FindAll();
            gridProduto.DataBind();
        }

        protected void gridProdutos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                ProdutoDal d = new ProdutoDal();
                d.Delete(Convert.ToInt32(gridProduto.DataKeys[e.RowIndex].Value.ToString()));

                lblMensagem.Text = "Produto Excluido.";

                gridBind();
            }
            catch (Exception ex)
            {

                lblMensagem.Text = "Erro ao deletar Produto." + ex.Message;
            }
        }

        protected void gridProduto_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridProduto.EditIndex = e.NewEditIndex;
            gridBind();
        }

        protected void gridProduto_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                int index = gridProduto.EditIndex;
                GridViewRow row = gridProduto.Rows[index];

                Produto p = new Produto();
                p.IdProduto = Convert.ToInt32(gridProduto.DataKeys[e.RowIndex].Value.ToString());
                p.Nome = Convert.ToString(((TextBox)(row.Cells[2].Controls[0])).Text);
                p.Preco = Convert.ToDecimal(((TextBox)(row.Cells[3].Controls[0])).Text);
                p.Quantidade = Convert.ToInt32(((TextBox)(row.Cells[4].Controls[0])).Text);
                p.Descricao = Convert.ToString(((TextBox)(row.Cells[5].Controls[0])).Text);

                ProdutoDal d = new ProdutoDal();
                d.Update(p);

                lblMensagem.Text = "Produto Atualizado.";

                gridProduto.EditIndex = -1;
                gridBind();

                
            }
            catch (Exception ex)
            {
                
                lblMensagem.Text = "Erro ao atualizar Produto" + ex.Message;
            }
        }

        protected void gridProduto_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridProduto.EditIndex = -1;
            gridBind();
        }

    }
}