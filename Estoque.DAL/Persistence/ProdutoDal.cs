using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Estoque.DAL.Entity;

namespace Estoque.DAL.Persistence
{
    public class ProdutoDal : Conexao
    {
        public void Insert(Produto p)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("INSERT INTO Produto(IdFornec, Nome, Preco, Quantidade, Descricao) VALUES(@v1, @v2, @v3, @v4, @v5)", Con);
                Cmd.Parameters.AddWithValue("@v1", p.IdFornecedor);
                Cmd.Parameters.AddWithValue("@v2", p.Nome);
                Cmd.Parameters.AddWithValue("@v3", p.Preco);
                Cmd.Parameters.AddWithValue("@v4", p.Quantidade);
                Cmd.Parameters.AddWithValue("@v5", p.Descricao);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
        public void Update(Produto p)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("UPDATE Produto SET Nome = @v1, Preco = @v2, Quantidade = @v3, Descricao = @v4 WHERE IdProduto = @v5", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Preco);
                Cmd.Parameters.AddWithValue("@v3", p.Quantidade);
                Cmd.Parameters.AddWithValue("@v4", p.Descricao);
                Cmd.Parameters.AddWithValue("@v5", p.IdProduto);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Produto> FindAll()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM Produto p, Fornecedor f WHERE p.IdFornec = f.IdFornecedor ", Con);
                Dr = Cmd.ExecuteReader();

                List<Produto> lista = new List<Produto>();

                while (Dr.Read())
                {
                    Produto p = new Produto();
                    Fornecedor f = new Fornecedor();
                    f.IdFornecedor = Convert.ToInt32(Dr["IdFornec"]);
                    f.Nome = Convert.ToString(Dr.GetString(7));
                    p.IdProduto = Convert.ToInt32(Dr["IdProduto"]);
                    p.Fornecedor = f;
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Preco = Convert.ToDecimal(Dr["Preco"]);
                    p.Quantidade = Convert.ToInt32(Dr["Quantidade"]);
                    p.Descricao = Convert.ToString(Dr["Descricao"]);

                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Delete(int IdProduto)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("DELETE FROM Produto WHERE IdProduto = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", IdProduto);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
