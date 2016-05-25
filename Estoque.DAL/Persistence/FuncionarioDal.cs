using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Estoque.Entity.Entities;
using Estoque.Util.Security;
using Estoque.DAL.DataSource;

namespace Estoque.DAL.Persistence
{
    public class FuncionarioDal : Conexao
    {
        public void Insert(Funcionario f)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT COUNT(*) FROM Funcionario WHERE Login = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", f.Login);
                int quantidade = Convert.ToInt32(Cmd.ExecuteScalar());

                if (quantidade == 0)
                {
                    Cmd = new SqlCommand("INSERT INTO Funcionario(Login, Nome, Senha) VALUES(@v1, @v2, @v3)", Con);
                    Cmd.Parameters.AddWithValue("@v1", f.Login);
                    Cmd.Parameters.AddWithValue("@v2", f.Nome);
                    Cmd.Parameters.AddWithValue("@v3", Criptografia.GetMD5Hash(f.Senha));
                    Cmd.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception("Erro ao cadastrar Funcionario, Login informado já existe.");

                }
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

        public Funcionario Authenticate(string Login, string Senha)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM Funcionario WHERE Login = @v1 AND Senha = @v2", Con);
                Cmd.Parameters.AddWithValue("@v1", Login);
                Cmd.Parameters.AddWithValue("@v2", Criptografia.GetMD5Hash(Senha));
                Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    Funcionario f = new Funcionario();
                    f.Matricula = Convert.ToInt32(Dr["Matricula"]);
                    f.Login = Convert.ToString(Dr["Login"]);
                    f.Nome = Convert.ToString(Dr["Nome"]);

                    return f;
                }
                else
                {
                    return null;
                }
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
