namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class PosicaoPreMatriculaAtualizadaIntegrationEvent : IntegrationEvent
{
    public Guid SolicitacaoId { get; private set; }

    public Guid EscolaPretendidaId { get; private set; }
    
    public Guid PreMatriculaId { get; private set; }

    public int Posicao { get; private set; }

    public string Observacao { get; private set; }

    public int Status { get; private set; }


    public PosicaoPreMatriculaAtualizadaIntegrationEvent(Guid solicitacaoId, Guid preMatriculaId, int posicao, string observacao, Guid escolaPretendidaId, int status)
    {
        SolicitacaoId = solicitacaoId;
        PreMatriculaId = preMatriculaId;
        Posicao = posicao;
        Observacao = observacao;
        EscolaPretendidaId = escolaPretendidaId;
        Status = status;
    }
}