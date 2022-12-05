using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MarketBay.Models;

[Table("FavFeirasCliente")]
[PrimaryKey("ClienteID", "FeiraID")]
public class FavFeirasCliente
{
    [ForeignKey("Cliente")]
    public int ClienteID;
    [ForeignKey("Feira")]
    public int FeiraID;
}