using MarketBay.Data;
using Microsoft.AspNetCore.Mvc;

namespace MarketBay.Controllers;

public class ClienteController : Controller
{

    private readonly DatabaseContext _databaseContext;

    public ClienteController(DatabaseContext _databaseContext)
    {
        this._databaseContext = _databaseContext;
    }
    
    // GET
    public IActionResult Index()
    {
        return View(this._databaseContext.Clientes.ToList());
    }
}