namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class BaixaDoEstoqueIntegrationEvent : IntegrationEvent
{
    public Guid UsuarioId { get; set; }
    public Guid EscolaId { get; set; }
    public string Observacao { get; set; }
    public string Itens { get; set; }
}
