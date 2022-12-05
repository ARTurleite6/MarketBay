using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MarketBay.Models;

[Table("Cliente")]
public class Cliente
{
    [Key]
    public int ID { get; set; }
    
    [ForeignKey("Conta")]
    public int ContaID { get; set; }
    public virtual Conta Conta { get; set; }
    
    public virtual ICollection<Categoria> Categorias { get; set; }
    public virtual ICollection<FavFeirasCliente> FeirasFavoritas { get; set; }
    
    public virtual ICollection<ClassificacoesCliente> ClassificacoesFeirante { get; set; }
    public virtual ICollection<Compra> Compras { get; set; }
}