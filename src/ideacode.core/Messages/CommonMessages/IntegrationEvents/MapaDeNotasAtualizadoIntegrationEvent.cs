namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class MapaDeNotasAtualizadoIntegrationEvent : IntegrationEvent
{
    public string AlunoId { get; set; }
    public int TurmaId { get; set; }

    public List<MapaDeNotasDisciplinaEvent> Disciplinas { get; set; }

    public MapaDeNotasAtualizadoIntegrationEvent()
    {
        Disciplinas = new List<MapaDeNotasDisciplinaEvent>();
    }

    public MapaDeNotasAtualizadoIntegrationEvent(string alunoId, int turmaId) : this()
    {
        AlunoId = alunoId;
        TurmaId = turmaId;
    }
}

public class MapaDeNotasDisciplinaEvent
{
    public string BoletimGuid { get; set; }
    public string AlunoGuid { get; set; }
    public string AlunoNome { get; set; }
    public int TurmaId { get; set; }
    public string TurmaDescricao { get; set; }
    public string DisciplinaGuid { get; set; }
    public string DisciplinaDescricao { get; set; }
    public int TotalDeFaltas { get; set; }
    public int DisciplinaTotalDeFaltas { get; set; }
    public double MediaAnual { get; set; }
    public double NotaRestante { get; set; }
    public string NotaRestanteFormatada { get; set; }

    public List<MapaMediaIntegrationEvent> Medias { get; set; } = new List<MapaMediaIntegrationEvent>();

    public MapaDeNotasDisciplinaEvent()
    {
    }

    public MapaDeNotasDisciplinaEvent(string boletimGuid, string alunoGuid, string alunoNome, int turmaId,
        string turmaDescricao, string disciplinaGuid, string disciplinaDescricao, int totalDeFaltas,
        int disciplinaTotalDeFaltas, double mediaAnual, double notaRestante, string notaRestanteFormatada,
        List<MapaMediaIntegrationEvent> medias)
    {
        BoletimGuid = boletimGuid;
        AlunoGuid = alunoGuid;
        AlunoNome = alunoNome;
        TurmaId = turmaId;
        TurmaDescricao = turmaDescricao;
        DisciplinaGuid = disciplinaGuid;
        DisciplinaDescricao = disciplinaDescricao;
        TotalDeFaltas = totalDeFaltas;
        DisciplinaTotalDeFaltas = disciplinaTotalDeFaltas;
        MediaAnual = mediaAnual;
        NotaRestante = notaRestante;
        NotaRestanteFormatada = notaRestanteFormatada;
        Medias = medias;
    }
}

public class MapaMediaIntegrationEvent
{
    public double Media { get; set; }
    public string MediaFormatada { get;  set; }
    public int Faltas { get; set; }
    public string BimestreDescricao { get; set; }


    public MapaMediaIntegrationEvent()
    {
    }

    public MapaMediaIntegrationEvent(double media, int faltas, string bimestreDescricao, string mediaFormatada)
    {
        Media = media < 0 ? 0 : media;
        Faltas = faltas < 0 ? 0 : faltas;
        BimestreDescricao = bimestreDescricao;
        MediaFormatada = mediaFormatada;
    }
}