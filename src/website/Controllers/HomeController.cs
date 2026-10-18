using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using website.Models;
using website.Services;

namespace website.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Treinamentos() => View();
   
    public IActionResult Assessment() => View();

    public IActionResult AplicacoesLegadas() => View();

    public IActionResult Refatoracao() => View();

    public IActionResult IaCorporativa() => View();

    [Route("Home/StatusCode")]
    public IActionResult StatusCode(int statusCode)
    {
        // Exibir uma página de erro específica com base no status code
        if (statusCode == 404)
        {
            return View("Error404");
        }

        return View("Error"); // Página de erro genérica
    }

    [Route("Home/contato")]
    public async Task<IActionResult> EnviarContato(
        [FromServices] IContatoServices contatoServices,
        ContatoInputModel model)
    {
        if (!ModelState.IsValid) return BadRequest("Houve um erro no envio do contato!");
        
        var contato = new ContatoDto()
        {
            Nome = model.Nome,
            Email = model.Email,
            Telefone = model.Telefone,
            Assunto = model.subject,
            Empresa = model.Empresa,
            Mensagem = model.Message
        };

        var result = await contatoServices.EnviarContato(contato);
        
        if (result.success) return Ok("OK");
        
        return BadRequest("Houve um erro no serviço de envio do contato!");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
