namespace ideacode.core.Messages.CommonMessages.IntegrationEvents
{
    public class SolicitacaoCanceladaIntegrationEvent : IntegrationEvent
    {
        public Guid SolicitacaoId { get; private set; }

        public SolicitacaoCanceladaIntegrationEvent(Guid solicitacaoId)
        {
            SolicitacaoId = solicitacaoId;
        }
    }
}