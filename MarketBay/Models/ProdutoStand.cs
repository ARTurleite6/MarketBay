using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MarketBay.Models;

[Table("ProdutoStand")]
[PrimaryKey("StandFeiranteID", "ProdutoID")]
public class ProdutoStand
{
    [ForeignKey("StandFeirante")]
    public int StandFeiranteID { get; set; }
    [ForeignKey("Produto")]
    public int ProdutoID { get; set; }
    [Precision(10, 2)]
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
}