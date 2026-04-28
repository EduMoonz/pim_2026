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

    // GET → abre a tela
    [HttpGet]
    public IActionResult Esqueciasenha()
    {
        return View();
    }

    // POST → recebe o formulário
    [HttpPost]
    public IActionResult Esqueciasenha(string email, string novaSenha, string confirmarSenha)
    {
        // Verifica se as senhas são diferentes
        if (novaSenha != confirmarSenha)
        {
            ViewBag.Erro = "As senhas não coincidem.";
            return View();
        }

        // Aqui depois você pode atualizar no banco
        ViewBag.Sucesso = "Senha redefinida com sucesso!";
        return View();
    }
}