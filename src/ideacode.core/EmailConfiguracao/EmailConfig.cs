namespace ideacode.core.EmailConfiguracao;

public class EmailConfig
{
    public string Assunto { get;  private set; }

    public string Conteudo { get; private set; }

    public string EnviadoPor { get; private set; }

    public string Titulo { get; private set; }
    

    public EmailConfig(string assunto, string conteudo, string enviadoPor, string titulo)
    {
        Assunto = assunto;
        Conteudo = conteudo;
        EnviadoPor = enviadoPor;
        Titulo = titulo;
    }
}