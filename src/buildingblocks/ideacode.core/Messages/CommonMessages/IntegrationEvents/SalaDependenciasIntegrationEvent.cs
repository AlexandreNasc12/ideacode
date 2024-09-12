namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class SalaDependenciasIntegrationEvent : IntegrationEvent
{
    public string AnoEscolar { get; private set; }
    public string Disciplina { get; private set; }
    public int AnoLetivo { get; private set; }
    public Guid EscolaId { get; private set; }
    public string NomeEscola { get; private set; }
    public Guid UsuarioId { get; private set; }
    public string MatriculaParticipante { get; private set; }
    public string NomeParticipante { get; private set; }
    public string FotoParticipante { get; private set; }
    public Guid ProfessorId { get; private set; }
    public Guid AnoEscolarId { get; private set; }

    public SalaDependenciasIntegrationEvent(string anoEscolar, string disciplina, int anoLetivo, Guid escolaId,
        string nomeEscola, Guid usuarioId, string matriculaParticipante,
        string nomeParticipante, string fotoParticipante, Guid professorId, Guid anoEscolarId)
    {
        AnoEscolar = anoEscolar;
        Disciplina = disciplina;
        AnoLetivo = anoLetivo;
        EscolaId = escolaId;
        NomeEscola = nomeEscola;
        UsuarioId = usuarioId;
        MatriculaParticipante = matriculaParticipante;
        NomeParticipante = nomeParticipante;
        FotoParticipante = fotoParticipante;
        ProfessorId = professorId;
        AnoEscolarId = anoEscolarId;
    }
}