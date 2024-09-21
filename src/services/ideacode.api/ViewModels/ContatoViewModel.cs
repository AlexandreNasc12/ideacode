using System;
using ideacode.api.Domain;

namespace ideacode.api.ViewModels;

public class ContatoViewModel
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Empresa { get; set; }
    public string Assunto { get; set; }
    public string Mensagem { get; set; }
    public string DataCadastro { get; set; }

    public static ContatoViewModel Mapear(Contato contato)
    {
        return new ContatoViewModel()
        {
            Id = contato.Id,
            Nome = contato.Nome,
            Assunto = contato.Assunto,
            Email = contato.Email.Endereco,
            Empresa = contato.Empresa,
            Mensagem = contato.Mensagem,
            DataCadastro = contato.DataDeCadastroFormatada
        };
    }
}
