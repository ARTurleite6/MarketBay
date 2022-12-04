namespace MarketBay.Models;

public class Cliente
{
    public int ID { get; set; }
    public int ContaID { get; set; }
    public virtual Conta Conta { get; set; }
}