namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class UsuarioCensoIntegrationEvent : IntegrationEvent
{
    public Guid UsuarioGuid { get; private set; }
    public int UsuarioId { get; private set; } 
    public string Matricula { get; private set; }
    public string NomeUsuario { get; private set; }

    public UsuarioCensoIntegrationEvent(Guid usuarioGuid, int usuarioId, string matricula, string nomeUsuario)
    {
        UsuarioGuid = usuarioGuid;
        UsuarioId = usuarioId;
        Matricula = matricula;
        NomeUsuario = nomeUsuario;
    }
}