using RDLSuperMarket.ORM;

namespace RDLSuperMarket.Model
{
    public class Venda
    {
        public int Id { get; set; }

        public byte[]? Notafv { get; set; }

        public decimal Valor { get; set; }

        public int Fkcliente { get; set; }

        public int Fkproduto { get; set; }

        public virtual TbCliente FkclienteNavigation { get; set; } = null!;

        public virtual TbProduto FkprodutoNavigation { get; set; } = null!;
    }
}
