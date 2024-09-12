namespace ideacode.core.Messages.CommonMessages.IntegrationEvents
{
    public class AlunoInfrequenteIntegrationEvent : IntegrationEvent
    {
        public string AlunoGuid { get; private set; }
        public int AlunoId { get; private set; }
        public string NomeAluno { get; private set; }
        public string NomeTurma { get; private set; }
        public Guid EscolaId { get; private set; }
        public string NomeEscola { get; private set; }
        public DateTime DataFalta { get; private set; }
        public string ResponsavelId { get; private set; }
        public string NomeResponsavel { get; private set; }
        public string EmailResponsavel { get; private set; }
        public string NumeroResponsavel { get; private set; }
        public bool SerieInicial { get; private set; }
        public DateTime DataNascimento { get; private set; }
        
        public List<DisciplinaInfrequente> Disciplinas { get; private set; }

        public AlunoInfrequenteIntegrationEvent(string alunoGuid, int alunoId, string nomeAluno, string nomeTurma, Guid escolaId, string nomeEscola, DateTime dataFalta, string responsavelId, string nomeResponsavel, string emailResponsavel, string numeroResponsavel, bool serieInicial, DateTime dataNascimento)
        {
            AlunoGuid = alunoGuid;
            AlunoId = alunoId;
            NomeAluno = nomeAluno;
            NomeTurma = nomeTurma;
            EscolaId = escolaId;
            NomeEscola = nomeEscola;
            DataFalta = dataFalta;

            Disciplinas = new List<DisciplinaInfrequente>();
            ResponsavelId = responsavelId;
            NomeResponsavel = nomeResponsavel;
            EmailResponsavel = emailResponsavel;
            NumeroResponsavel = numeroResponsavel;
            SerieInicial = serieInicial;
            DataNascimento = dataNascimento;
        }
    }
}