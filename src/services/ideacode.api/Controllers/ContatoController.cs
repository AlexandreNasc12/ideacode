using ideacode.api.core.Controllers;
using ideacode.api.Infra.Data;
using ideacode.api.InputModel;
using Microsoft.AspNetCore.Mvc;

namespace ideacode.api.Controllers;

[Route("api/contato")]
public class ContatoController : MainController
{
    private readonly IdeaCodeContext _context;

    public ContatoController(IdeaCodeContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AdicionarContato(ContatoInputModel model)
    {
        if (!ModelState.IsValid) return CustomResponse(ModelState);

        return CustomResponse();
    }
}