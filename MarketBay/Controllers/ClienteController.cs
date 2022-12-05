using MarketBay.Data;
using MarketBay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MarketBay.Controllers;

public class ClienteController : Controller
{

    private readonly DatabaseContext _context;

    public ClienteController(DatabaseContext context)
    {
        this._context = context;
    }
    
    [HttpGet]
    public IActionResult Index(int id)
    {
        Console.WriteLine(id);
        var cliente = _context.Clientes
            .Include(cliente => cliente.Conta)
            .Where(cliente => cliente.ContaID == id)
            .Select(cliente => cliente)
            .First();
        
        return View(cliente);
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
        this._context.Add(cliente);
        this._context.SaveChanges();
        return View();
    }

    // GET
    /*
    public IActionResult Get()
    {
        return View(this._context.Clientes.ToList());
    }
    */
}