using ideacode.core.DomainObjects;
using ideacode.core.ValueObjects;

namespace ideacode.api.Domain;

public class Contato : Entity
{
    public string Nome { get; private set; }
    public Email Email { get; private set; }
    public string Empresa { get; private set; }
    public string Assunto { get; private set; }
    public string Mensagem { get; private set; }
    
    protected Contato(){}

    public Contato(string nome, Email email, string empresa, string assunto, string mensagem)
    {
        Nome = nome;
        Email = email;
        Empresa = empresa;
        Assunto = assunto;
        Mensagem = mensagem;
    }
}