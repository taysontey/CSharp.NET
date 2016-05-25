using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Estoque.Entity.Entities;
using Estoque.DAL.DataSource;

namespace Estoque.DAL.Persistence
{
    public class FornecedorDal : Conexao
    {
        public void Insert(Fornecedor f)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("INSERT INTO Fornecedor(Nome) VALUES(@v1)", Con);
                Cmd.Parameters.AddWithValue("@v1", f.Nome);
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

        public List<Fornecedor> FindAll()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM Fornecedor", Con);
                Dr = Cmd.ExecuteReader();

                List<Fornecedor> lista = new List<Fornecedor>();

                while (Dr.Read())
                {
                    Fornecedor f = new Fornecedor();
                    f.IdFornecedor = Convert.ToInt32(Dr["IdFornecedor"]);
                    f.Nome = Convert.ToString(Dr["Nome"]);

                    lista.Add(f);
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

        public void Delete(int IdFornecedor)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("DELETE FROM Fornecedor WHERE IdFornecedor = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", IdFornecedor);
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
