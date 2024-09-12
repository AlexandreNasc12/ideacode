namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;


public class TurmaCensoIntegrationEvent : IntegrationEvent
{
    public int TurmaId { get; private set; }
    public int EscolaId { get; private set; } 
    public bool Segunda { get; private set; }
    public bool Terca { get; private set; }
    public bool Quarta { get; private set; }
    public bool Quinta { get; private set; }
    public bool Sexta { get; private set; }
    public bool Sabado { get; private set; }
    public bool Domingo { get; private set; }
    public string HorarioInicial { get; private set; }
    public string HorarioFinal { get; private set; }
    
    public TurmaCensoIntegrationEvent(int turmaId, int escolaId, bool segunda, bool terca, bool quarta, bool quinta, bool sexta, bool sabado, bool domingo, string horarioInicial, string horarioFinal)
    {
        TurmaId = turmaId;
        EscolaId = escolaId;
        Segunda = segunda;
        Terca = terca;
        Quarta = quarta;
        Quinta = quinta;
        Sexta = sexta;
        Sabado = sabado;
        Domingo = domingo;
        HorarioInicial = horarioInicial;
        HorarioFinal = horarioFinal;
    }
}