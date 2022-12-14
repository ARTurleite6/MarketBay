using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace MarketBay.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    public int ID { get; set; }
    [MaxLength(50)]
    public string Nome { get; set; }
    [MaxLength(200)]
    public string Foto{ get; set; }
    [MaxLength(250)]
    public string Descricao{ get; set; }
    [Precision(10,2)]
    public decimal PrecoBase { get; set; }
    
    [ForeignKey("Categoria")]
    public int CategoriaID { get; set; }
    public Categoria Categoria { get; set; }
}