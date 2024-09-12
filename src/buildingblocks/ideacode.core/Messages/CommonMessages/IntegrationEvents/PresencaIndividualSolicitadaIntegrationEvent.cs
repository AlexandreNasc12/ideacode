namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public sealed class PresencaIndividualSolicitadaIntegrationEvent : IntegrationEvent
{
    public int AlunoId { get; set; }
    public DateTime DataAula { get; set; }

    public PresencaIndividualSolicitadaIntegrationEvent()
    {
    }

    public PresencaIndividualSolicitadaIntegrationEvent(int alunoId, DateTime dataAula)
    {
        AlunoId = alunoId;
        DataAula = dataAula;
    }
}
