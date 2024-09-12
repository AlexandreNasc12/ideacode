namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class IntegracaoDeFrequenciaServicoExternoIntegrationEvent : IntegrationEvent
{
    public int FrequenciaId { get; private set; }
    public int HorarioId { get; private set; }
    public int AlunoId { get; private set; }
    public bool Presenca { get; private set; }
    public string Justificativa { get; private set; }
    public DateTime DataJustificativa { get; private set; }
    public DateTime DataDeAula { get; private set; }
    public int? JustificativaFrequenciaId { get; private set; }
    public int? UsuarioId { get; private set; }
    public bool Online { get; private set; }
    public bool Material { get; private set; }
    public string HorarioInicio { get; private set; }
    public string HorarioFim { get; private set; }
    public int? TurmaId { get; private set; }
    public int? EscolaId { get; private set; }
    public string DisciplinaDescricao { get; private set; }
    public DateTime DataDeCadastroFrequencia { get; private set; }
    public DateTime DataDeAlteracaoFrequencia { get; private set; }
    public bool EhAtualizacao { get; private set; }
    public string FrequenciaIdGuid { get; private set; }
    
    public IntegracaoDeFrequenciaServicoExternoIntegrationEvent(int frequenciaId, int horarioId, int alunoId, bool presenca, string justificativa, DateTime dataJustificativa, DateTime dataDeAula, int? justificativaFrequenciaId, int? usuarioId, bool online, bool material, string horarioInicio, string horarioFim, int? turmaId, int? escolaId, string disciplinaDescricao, DateTime dataDeCadastroFrequencia, DateTime dataDeAlteracaoFrequencia, bool ehAtualizacao, string frequenciaIdGuid)
    {
        FrequenciaId = frequenciaId;
        HorarioId = horarioId;
        AlunoId = alunoId;
        Presenca = presenca;
        Justificativa = justificativa;
        DataJustificativa = dataJustificativa;
        DataDeAula = dataDeAula;
        JustificativaFrequenciaId = justificativaFrequenciaId;
        UsuarioId = usuarioId;
        Online = online;
        Material = material;
        HorarioInicio = horarioInicio;
        HorarioFim = horarioFim;
        TurmaId = turmaId;
        EscolaId = escolaId;
        DisciplinaDescricao = disciplinaDescricao;
        DataDeCadastroFrequencia = dataDeCadastroFrequencia;
        DataDeAlteracaoFrequencia = dataDeAlteracaoFrequencia;
        EhAtualizacao = ehAtualizacao;
        FrequenciaIdGuid = frequenciaIdGuid;
    }
}