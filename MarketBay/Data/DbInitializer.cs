using MarketBay.Models;

namespace MarketBay.Data;

public static class DbInitializer
{
    public static void Initialize(DatabaseContext context)
    {
        context.Database.EnsureCreated();

        if (!context.Contas.Any()) return;
        var conta = new Conta()
        {
            Email = "teste1@gmai.com",
            Nome = "conta1",
            Password = "1234",
            NumeroTelemovel = "912313456",
        };
        context.Contas.Add(conta);
        context.SaveChanges();
    }
}