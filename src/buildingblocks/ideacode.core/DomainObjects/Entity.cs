using FluentValidation.Results;
using ideacode.core.Helpers;
using ideacode.core.Messages;

namespace ideacode.core.DomainObjects
{
    public abstract class Entity : Aggregate
    {
        public Guid Id { get; private set; }
        public DateTime DataDeCadastro { get; private set; }
        public DateTime DataDeAlteracao { get; private set; }
        public bool Lixeira { get; private set; }

        public ValidationResult ValidationResult { get; private set; }

        private List<Event> _notificacoes;
        public IReadOnlyCollection<Event> Notificacoes => _notificacoes?.AsReadOnly();

        public void AdicionarEvento(Event evento)
        {
            _notificacoes ??= new List<Event>();
            _notificacoes.Add(evento);
        }

        public void RemoverEvento(Event eventItem)
        {
            _notificacoes?.Remove(eventItem);
        }

        public void LimparEventos()
        {
            _notificacoes?.Clear();
        }

        protected void AdicionarErrosDaEntidade(string mensagem)
        {
            ValidationResult.Errors.Add(new ValidationFailure(string.Empty,mensagem));
        }

        // Datas são persistidas em UTC (Kind=Utc) e convertidas para Brasília
        // apenas na exibição, seguindo a convenção "timestamp with time zone" do PostgreSQL.
        public string DataDeAlteracaoFormatada
        {
            get
            {
                if (DataDeAlteracao == default(DateTime))
                    return null;

                return DataHoraDeBrasilia.Set(DataDeAlteracao).ToString("dd/MM/yyyy");
            }
        }

        public string DataDeCadastroFormatada
        {
            get
            {
                if (DataDeCadastro == default(DateTime))
                    return null;

                return DataHoraDeBrasilia.Set(DataDeCadastro).ToString("dd/MM/yyyy");
            }
        }

        public void SetEntidadeId(Guid NovoId) => Id = NovoId;

        public virtual void EnviarParaLixeira() => Lixeira = true;

        public void RestaurarDaLixeira() => Lixeira = false;

        public void SetDataDeAlteracao() => DataDeAlteracao = DateTime.UtcNow;

        public void SetDataDeCadastro(DateTime data) => DataDeCadastro = ParaUtc(data);

        // Normaliza para UTC antes da persistência: valores Kind=Local são convertidos
        // e valores Kind=Unspecified são tratados como UTC.
        private static DateTime ParaUtc(DateTime data)
        {
            return data.Kind switch
            {
                DateTimeKind.Local => data.ToUniversalTime(),
                DateTimeKind.Unspecified => DateTime.SpecifyKind(data, DateTimeKind.Utc),
                _ => data
            };
        }

        public Entity()
        {
            Id = Guid.NewGuid();
            DataDeCadastro = DateTime.UtcNow;
            DataDeAlteracao = DateTime.UtcNow;

            ValidationResult = new ValidationResult();
        }

        #region Comparações

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }

        #endregion

    }
}

