namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class RequisicaoDeMatriculaResponseIntegrationEvent : IntegrationEvent
{
    public Guid ResponsavelId { get; set; }

    public Guid AlunoId { get; set; }

    public Guid SerieId { get; set; }

    public int TurnoId { get; set; }

    public DateTime DataDeDivulgacao { get; set; }

    public DateTime DataLimiteEfetivacao { get; set; }

    public List<EscolasPretentidasIntegrationDto> Escolas { get; set; }

    public RequisicaoDeMatriculaResponseIntegrationEvent(Guid responsavelId, Guid alunoId, Guid serieId,
        int turnoId, List<EscolasPretentidasIntegrationDto> escolas, DateTime dataLimiteEfetivacao, DateTime dataDeDivulgacao)
    {
        ResponsavelId = responsavelId;
        AlunoId = alunoId;
        SerieId = serieId;
        TurnoId = turnoId;
        Escolas = escolas;
        DataLimiteEfetivacao = dataLimiteEfetivacao;
        DataDeDivulgacao = dataDeDivulgacao;
    }
}