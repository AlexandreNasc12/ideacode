namespace ideacode.core.Messages.CommonMessages.IntegrationEvents.Relatorio
{
    public partial class RelatorioCensoAlunoEvent : IntegrationEvent
    {
    }
    
    public class RelatorioFrequenciaEvent : IntegrationEvent
    {
        public bool SerieInicial { get; set; }
    }
    
    public class RelatorioNotaEvent : IntegrationEvent
    {
    }
    
    public partial class RelatorioResponsaveisEvent : IntegrationEvent
    {
    }
}