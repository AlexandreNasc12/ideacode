namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class GerarRestricoesIntegrationEvent : IntegrationEvent
{
    public Guid AlunoId { get; private set; }
    public Guid DisciplinaId { get; private set; }
    public int EscolaId { get; private set; }
    public int SerieId { get; private set; }

    public GerarRestricoesIntegrationEvent(Guid alunoId, Guid disciplinaId, int escolaId, int serieId)
    {
        AlunoId = alunoId;
        DisciplinaId = disciplinaId;
        EscolaId = escolaId;
        SerieId = serieId;
    }
}
