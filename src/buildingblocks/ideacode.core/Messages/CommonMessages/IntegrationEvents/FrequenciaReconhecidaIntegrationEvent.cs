namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class FrequenciaReconhecidaIntegrationEvent : IntegrationEvent
{
    public int HorarioId { get; set; }
    public DateTime DataDeAula { get; set; }
    public int DisciplinaId { get; set; }
    public int UsuarioId { get;  set; }

    public IEnumerable<FrequenciaReconhecidaAlunoIntegrationEvent> Alunos { get; set; } =
        new List<FrequenciaReconhecidaAlunoIntegrationEvent>();

    public FrequenciaReconhecidaIntegrationEvent()
    {
    }

    public FrequenciaReconhecidaIntegrationEvent(int horarioId, DateTime dataDeAula, int disciplinaId, int usuarioId,
        IEnumerable<FrequenciaReconhecidaAlunoIntegrationEvent> alunos)
    {
        HorarioId = horarioId;
        DataDeAula = dataDeAula;
        DisciplinaId = disciplinaId;
        UsuarioId = usuarioId;
        Alunos = alunos;
    }
}

public class FrequenciaReconhecidaAlunoIntegrationEvent
{
    public int AlunoId { get; set; }
    public bool Presenca { get; set; }

    public FrequenciaReconhecidaAlunoIntegrationEvent()
    {
    }

    public FrequenciaReconhecidaAlunoIntegrationEvent(int alunoId, bool presenca)
    {
        AlunoId = alunoId;
        Presenca = presenca;
    }
}
