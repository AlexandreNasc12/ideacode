namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class GerarBoletimIntegrationEvent : IntegrationEvent
{
    public Guid EnturmamentoId { get; set; }

    public GerarBoletimIntegrationEvent(Guid enturmamentoId)
    {
        EnturmamentoId = enturmamentoId;
    }
}

public class BoletimAtualizadoIntegrationEvent : IntegrationEvent
{
    public int AlunoId { get; private set; }
        
    public BoletimAtualizadoIntegrationEvent(int alunoId)
    {
        AlunoId = alunoId;
    }
}