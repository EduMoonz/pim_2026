using PIM_2026.Models;
using Microsoft.AspNetCore.Mvc;

public class ContaController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Cadastro()
    {
        return View();
    }

    public IActionResult Esqueciasenha()
    {
        return View();
    }
}