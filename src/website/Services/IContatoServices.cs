using ideacode.api.core;
using ideacode.api.core.Identidade;
using ideacode.core.Communication;
using Microsoft.Extensions.Options;
using website.Configuration;

namespace website.Services;

public interface IContatoServices
{
    Task<ResponseResult> EnviarContato(ContatoDto contatoDto);
}

public class ContatoServices : Service, IContatoServices
{   
    private readonly HttpClient _httpClient;

    public ContatoServices(HttpClient httpClient, IOptions<HttpUrls> options)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(options.Value.IdeaWebApi);
    }
    
    public async Task<ResponseResult> EnviarContato(ContatoDto contatoDto)
    {
        var result = await _httpClient.PostAsJsonAsync("api/contato", contatoDto);

        return await DeserializarObjetoResponse<ResponseResult>(result);
    }
}