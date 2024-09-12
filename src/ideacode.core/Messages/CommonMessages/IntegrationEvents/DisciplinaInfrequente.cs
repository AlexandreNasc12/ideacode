namespace ideacode.core.Messages.CommonMessages.IntegrationEvents
{
    public class DisciplinaInfrequente
    {
        public string Id { get; private set; }
        public string Descricao { get; private set; }

        public DisciplinaInfrequente(string id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}