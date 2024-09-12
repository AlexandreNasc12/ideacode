namespace ideacode.core.Messages.CommonMessages.IntegrationEvents;

public class BoletimLegadoParanaIntegrationEvent : IntegrationEvent
{
    public string boletimId { get; set; }
    public int ano { get; set; }
    public string anoLetivo { get; set; }
    public string FrequenciaGlobalTurma { get; set; }
    public int totalDeFrequenciaGlobal { get; set; }
    public int totalDeFaltasJustificadas { get; set; }
    public string situacaoFinal { get; set; }
    public string CR { get; set; }
    public string nomeAluno { get; set; }
    public string nomeEscola { get; set; }
    public string matriculaAluno { get; set; }
    public string turma { get; set; }
    public string turno { get; set; }
    public string alunoId { get; set; }
    public int idAluno { get; set; }
    public string observacao { get; set; }
    public bool aprovadoPeloConselho { get; set; }
    public int turmaId { get; set; }
    public string serieDescricao { get; set; }
    public bool Personalizado { get; set; }
    public bool serieInicial { get; set; }
    public int SerieId { get; set; }
    public DateTime menorDataPeriodo { get; set; }
    public DateTime maiorDataPeriodo { get; set; }
    public bool pne { get; set; }

    public List<DisciplinaBoletimItemDto> ItensDeDisciplinas { get; set; } = new();
    public List<ItemBoletimBimestreDto> ItensPeriodo { get; set; } = new ();

    public BoletimLegadoParanaIntegrationEvent()
    {
    }
    
    public BoletimLegadoParanaIntegrationEvent(string boletimId, int ano, string anoLetivo, string frequenciaGlobalTurma, int totalDeFrequenciaGlobal, int totalDeFaltasJustificadas, string situacaoFinal, 
        string cr, string nomeAluno, string nomeEscola, string matriculaAluno, string turma, string turno, string alunoId, int idAluno, string observacao, bool aprovadoPeloConselho, int turmaId, 
        string serieDescricao, bool personalizado, bool serieInicial, int serieId, DateTime menorDataPeriodo, DateTime maiorDataPeriodo, 
        bool pne, List<DisciplinaBoletimItemDto> itensDeDisciplinas, List<ItemBoletimBimestreDto> itensPeriodo)
    {
        this.boletimId = boletimId;
        this.ano = ano;
        this.anoLetivo = anoLetivo;
        FrequenciaGlobalTurma = frequenciaGlobalTurma;
        this.totalDeFrequenciaGlobal = totalDeFrequenciaGlobal;
        this.totalDeFaltasJustificadas = totalDeFaltasJustificadas;
        this.situacaoFinal = situacaoFinal;
        CR = cr;
        this.nomeAluno = nomeAluno;
        this.nomeEscola = nomeEscola;
        this.matriculaAluno = matriculaAluno;
        this.turma = turma;
        this.turno = turno;
        this.alunoId = alunoId;
        this.idAluno = idAluno;
        this.observacao = observacao;
        this.aprovadoPeloConselho = aprovadoPeloConselho;
        this.turmaId = turmaId;
        this.serieDescricao = serieDescricao;
        Personalizado = personalizado;
        this.serieInicial = serieInicial;
        SerieId = serieId;
        this.menorDataPeriodo = menorDataPeriodo;
        this.maiorDataPeriodo = maiorDataPeriodo;
        this.pne = pne;
        ItensDeDisciplinas = itensDeDisciplinas;
        ItensPeriodo = itensPeriodo;
    }
}

public class DisciplinaBoletimItemDto
{
    public int DisciplinaId { get; set; }
    public string DisciplinaGuidId { get; set; }
    public string DisciplinaDescricao { get; set; }
    public string mediaTotal { get; set; }
    public double mediaParaCalculoAprovacao { get; set; }
    public int totalFaltas { get; set; }
    public string porcentagemDeFrequencia { get; set; }
    public double percentualFrequenciaCalculoAprovacao { get; set; }
    public string status { get; set; }
    
    public string mediaFaltasString { get; set; }
    public string mediasString { get; set; }
    
    public List<string> mediaFaltas { get; set; }
    public ICollection<object> medias { get; set; }
    
    public DisciplinaBoletimItemDto()
    {
        mediaFaltas = new List<string>();
    }
}

public class ItemBoletimBimestreDto
{
    public int idPeriodo { get; set; }
    public string periodo { get; set; }
    public DateTime dataInicio { get; set; }
    public DateTime dataFim { get; set; }

    public string guid { get; set; }
}