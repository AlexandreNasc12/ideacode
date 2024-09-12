namespace ideacode.core.Messages.CommonMessages.IntegrationEvents
{
    public class RequisicaoDeMatriculaIntegrationEvent : IntegrationEvent
    {
        public Guid ResponsavelId { get; set; }

        public Guid AlunoId { get; set; }

        public Guid SerieId { get; set; }

        public int TurnoId { get; set; }

        public DateTime DataDeDivulgacao { get; set; }

        public DateTime DataLimiteEfetivacao { get; set; }

        public List<EscolasPretentidasIntegrationDto> Escolas { get; set; }

        public RequisicaoDeMatriculaIntegrationEvent(Guid responsavelId, Guid alunoId, Guid serieId,
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

    public class EscolasPretentidasIntegrationDto
    {
        public Guid EscolaId { get; set; }

        public bool PossuiIrmao { get; set; }

        public string MatriculaDoIrmao { get; set; }

        public int Posicao { get; set; }
    }
}