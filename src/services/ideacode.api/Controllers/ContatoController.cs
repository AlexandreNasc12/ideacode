using ideacode.api.core.Controllers;
using ideacode.api.Domain;
using ideacode.api.Infra.Data;
using ideacode.api.InputModel;
using ideacode.api.ViewModels;
using ideacode.core.ValueObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ideacode.api.Controllers;

[Route("api/contato")]
public class ContatoController : MainController
{
    private readonly IdeaCodeContext _context;

    public ContatoController(IdeaCodeContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> ObterContatos()
    {
        var contatos = await _context.Contatos
                                     .OrderByDescending(c => c.DataDeCadastro)
                                     .ToListAsync();
        var contatosViewModels = contatos.Select(ContatoViewModel.Mapear);

        return CustomResponse(contatosViewModels);
    }

    [HttpPost]
    public async Task<IActionResult> AdicionarContato(ContatoInputModel model)
    {
        if (!ModelState.IsValid) return CustomResponse(ModelState);

        var email = new Email(model.Email);

        var contato = new Contato(model.Nome,email,model.Empresa,model.Assunto,model.Mensagem);

        _context.Contatos.Add(contato);

        if (await _context.SaveChangesAsync() > 0)
        {
            //Enviar e-mail
            return CustomResponse();
        }

        AdicionarErroProcessamento("Não foi possível enviar seu contato neste momento!");
        return CustomResponse();
    }
}