namespace ideacode.core.Messages.CommonMessages.IntegrationEvents
{

    public class FrequenciaLancadaIntegrationEvent : IntegrationEvent
    {
        public int HorarioId { get; private set; }
        public int AlunoId { get; private set; }
        public int DisciplinaId { get; private set; }
        public bool Presenca { get; private set; }
        public DateTime DataDeAula { get; private set; }
        public int? UsuarioId { get; private set; }
        public bool Material { get; private set; }
        public bool PermitirLancamentoRetroativo { get; set; }
        public bool HabilitadoParaFrequencia { get; set; }
        public bool Notificar { get;  set; }

        public FrequenciaLancadaIntegrationEvent(
            int horarioId,
            int alunoId,
            int disciplinaId,
            bool presenca,
            DateTime dataDeAula,
            int? usuarioId,
            bool material,
            bool permitirLancamentoRetroativo,
            bool habilitadoParaFrequencia, bool notificar)
        {
            HorarioId = horarioId;
            AlunoId = alunoId;
            DisciplinaId = disciplinaId;
            Presenca = presenca;
            DataDeAula = dataDeAula;
            UsuarioId = usuarioId;
            Material = material;
            PermitirLancamentoRetroativo = permitirLancamentoRetroativo;
            HabilitadoParaFrequencia = habilitadoParaFrequencia;
            Notificar = notificar;
        }
    }

    public class FrequenciaProcessadaIntegrationEvent : IntegrationEvent{ }
}