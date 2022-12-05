using System.Diagnostics;
using MarketBay.Data;
using Microsoft.AspNetCore.Mvc;
using MarketBay.Models;

namespace MarketBay.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DatabaseContext _context;

    public HomeController(ILogger<HomeController> logger, DatabaseContext _context)
    {
        this._logger = logger;
        this._context = _context;
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        Console.WriteLine(email);
        var conta = _context.Contas.Where(conta => conta.Email == email)
            .Select(conta => new { conta.ID, conta.Password });
        if (!conta.Any())
        {
            Console.WriteLine("Login não ocorreu com sucesso");
        }
        else
        {
            var contaPassword = conta.First();
            Console.WriteLine(contaPassword);
            if (contaPassword.Password != password)
            {
                Console.WriteLine("Palavra passe incorreta");
            }
            else
            {
                Console.WriteLine("Login com sucesso");
                if (_context.Clientes.Where(c => c.ContaID == contaPassword.ID).Any())
                {
                    return RedirectToAction("Index", "Cliente", new { id = contaPassword.ID });
                }
                else
                {
                    //Feirante
                    return View();
                }
            }
            }

        return View();
    }

    [HttpGet]
    public IActionResult Login()
    {

        return View();
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

