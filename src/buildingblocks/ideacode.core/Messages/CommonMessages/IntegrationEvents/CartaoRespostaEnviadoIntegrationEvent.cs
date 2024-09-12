namespace ideacode.core.Messages.CommonMessages.IntegrationEvents
{
    public class CartaoRespostaEnviadoIntegrationEvent : IntegrationEvent
    {
        public Guid TemplateId { get; private set; }

        public Guid AlunoId { get; private set; }

        public string Respostas { get; private set; }

        public CartaoRespostaEnviadoIntegrationEvent(Guid templateId, Guid alunoId, string respostas)
        {
            TemplateId = templateId;
            AlunoId = alunoId;
            Respostas = respostas;
        }
    }
}