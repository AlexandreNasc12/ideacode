namespace ideacode.core.Messages.CommonMessages.IntegrationEvents
{
    public class EstatisticaDeCartaoPostadoIntegrationEvent : IntegrationEvent
    {
        public Guid TemplateId { get; private set; }

        public Guid CartaoId { get; private set; }

        public EstatisticaDeCartaoPostadoIntegrationEvent(Guid templateId, Guid cartaoId)
        {
            TemplateId = templateId;
            CartaoId = cartaoId;
        }
    }
}