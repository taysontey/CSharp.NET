using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Entity.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }       
        public int IdFornecedor { get; set; }

        #region Relacionamentos

        public Fornecedor Fornecedor { get; set; }

        #endregion
    }
}
