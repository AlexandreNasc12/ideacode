namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class UsuarioAtualizadoIntegrationEvent : IntegrationEvent
{
    public int Id { get; set; }
    public string EntityGuid { get; set; }
    public string Foto { get; set; }
    public string FotoComDiretorio { get;  set; }
    public string Nome { get; set; }
}