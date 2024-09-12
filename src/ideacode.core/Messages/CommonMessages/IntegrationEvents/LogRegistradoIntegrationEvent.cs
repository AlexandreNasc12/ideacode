namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class LogRegistradoIntegrationEvent : IntegrationEvent
{
    public Guid UsuarioId { get; set; }
    public string Email { get; set; }
    public int Acao { get; set; }
    public int AreaDoSistema { get; set; }
    public string Mensagem { get; set; }
    public string Conteudo { get; set; }

    public LogRegistradoIntegrationEvent(Guid usuarioId, string email, int acao, int areaDoSistema, string mensagem, string conteudo)
    {
        UsuarioId = usuarioId;
        Email = email;
        Acao = acao;
        AreaDoSistema = areaDoSistema;
        Mensagem = mensagem;
        Conteudo = conteudo;
    }
}
