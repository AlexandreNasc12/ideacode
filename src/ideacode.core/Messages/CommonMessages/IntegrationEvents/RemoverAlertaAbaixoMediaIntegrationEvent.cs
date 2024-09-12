
namespace ideacode.core.Messages.CommonMessages.IntegrationEvents
{
    public class RemoverAlertaAbaixoMediaIntegrationEvent : IntegrationEvent
    {
        public Guid AlunoId { get; set; }
        public Guid DisciplinaId { get; set; }

        public RemoverAlertaAbaixoMediaIntegrationEvent(Guid alunoId, Guid disciplinaId)
        {
            AlunoId = alunoId;
            DisciplinaId = disciplinaId;
        }
    }
}