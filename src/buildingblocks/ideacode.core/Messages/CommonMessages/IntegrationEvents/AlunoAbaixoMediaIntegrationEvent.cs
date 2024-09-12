namespace ideacode.core.Messages.CommonMessages.IntegrationEvents
{
    public class AlunoAbaixoMediaIntegrationEvent : IntegrationEvent
    {
        public int AlunoId { get; set; }
        public string AlunoGuid { get; set; }
        public string NomeDoAluno { get; set; }
        public int EscolaId { get; set; }
        public string NomeEscola { get; set; }
        public int TurmaId { get; set; }
        public string TurmaDescricao { get; set; }
        public int Ano { get; set; }
        public int SerieId { get; set; }
        public string SerieDescricao { get; set; }
        public int EnturmamentoId { get; set; }
        public string Media { get; set; }
        public bool Eja { get; set; }
        public string Foto { get; set; }
        public string Matricula { get; set; }
        public string EscolaGuid { get; set; }
        public int DisciplinaId { get; set; }

        public string DisciplinaGuidId { get; set; }

        public string DisciplinaDescricao { get; set; }

        public AlunoAbaixoMediaIntegrationEvent(int alunoId, string alunoGuid, string nomeDoAluno, int escolaId,
            string nomeEscola, int turmaId, string turmaDescricao, int ano, int serieId, string serieDescricao,
            int enturmamentoId, string media, bool eja, string escolaGuid)
        {
            AlunoId = alunoId;
            AlunoGuid = alunoGuid;
            NomeDoAluno = nomeDoAluno;
            EscolaId = escolaId;
            NomeEscola = nomeEscola;
            TurmaId = turmaId;
            TurmaDescricao = turmaDescricao;
            Ano = ano;
            SerieId = serieId;
            SerieDescricao = serieDescricao;
            EnturmamentoId = enturmamentoId;
            Media = media;
            Eja = eja;
            EscolaGuid = escolaGuid;
        }

        public void AtribuirFoto(string value) => Foto = value;
        public void AtribuirMatriculaUsuario(string value) => Matricula = value;
        public void AtribuirDisciplinaId(int value) => DisciplinaId = value;
        public void AtribuirDisciplinaGuid(string value) => DisciplinaGuidId = value;
        public void AtribuirDisciplinaDescricao(string value) => DisciplinaDescricao = value;

    }
}