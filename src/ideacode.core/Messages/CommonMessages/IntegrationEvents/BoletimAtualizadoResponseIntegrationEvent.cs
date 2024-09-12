namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class BoletimAtualizadoResponseIntegrationEvent : IntegrationEvent
{
    public int TurmaId { get; set; }
    public int[] Alunos { get; set; }

    public BoletimAtualizadoResponseIntegrationEvent(int[] alunos, int turmaId = 0)
    {
        TurmaId = turmaId;
        Alunos = alunos;
    }

    public bool ConfiguradoPorTurma() => TurmaId != 0;
} 