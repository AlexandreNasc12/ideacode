namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class NotificationEvent : IntegrationEvent
{
    public string UsuarioId { get; set; }
    public string EscolaId { get; set; }
    public string TurmaId { get; set; }
    public Destinatario Destinatario { get; set; }
    public string TipoPermissao { get; set; }
    public string Header { get; set; }
    public string Content { get; set; }
}
    
public enum Destinatario
{
    Aluno = 1,
    Responsavel = 2,
    AlunoResponsavel = Aluno | Responsavel,
    Professor = 4,
    Turmas = 5,
    Todos = Aluno | Responsavel | Professor
}

public enum TipoPermissaoNotificacao
{
    Frequência,
    Avaliação,
    Área_De_Acesso,
    Refeitório,
    Mural,
    Aviso,
    Enquete,
    Campanha,
    Aula_Ao_Vivo,
    Transporte
}