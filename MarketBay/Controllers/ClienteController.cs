using MarketBay.Data;
using MarketBay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MarketBay.Controllers;

public class ClienteController : Controller
{

    private readonly DatabaseContext _databaseContext;

    public ClienteController(DatabaseContext _databaseContext)
    {
        this._databaseContext = _databaseContext;
    }
    
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    //GET
    [HttpPost]
    public IActionResult Register(Cliente cliente)
    {
        this._databaseContext.Add(cliente);
        this._databaseContext.SaveChanges();
        return View();
    }

    // GET
    public IActionResult Index()
    {
        return View(this._databaseContext.Clientes.ToList());
    }
}