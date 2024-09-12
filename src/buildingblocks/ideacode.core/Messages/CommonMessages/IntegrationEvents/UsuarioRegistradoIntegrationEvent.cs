namespace ideacode.core.Messages.CommonMessages.IntegrationEvents
{
    public class UsuarioRegistradoIntegrationEvent : IntegrationEvent
    {
        public string Matricula { get; private set; }

        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public string Email { get; private set; }

        public string RgNumero { get; private set; }

        public string RgOrgaoEmissor { get; private set; }

        public string RgPaisEmissor { get; private set; }

        public DateTime? RgDataDeEmissao { get; private set; }

        public string Telefone { get; private set; }

        public string Celular { get; private set; }

        public string Foto { get; private set; }

        public string NomeOriginal { get; private set; }

        public bool Inativo { get; private set; }

        public int Sexo { get; private set; }

        public bool Pne { get; private set; }

        public int TipoUsuario { get; private set; }

        public int TipoSanguineo { get; private set; }

        public string Observacao { get; private set; }

        public string OrientacoesMedicas { get; private set; }

        public int Religiao { get; private set; }

        public string Doenca { get; private set; }

        public string Alergia { get; private set; }

        public DateTime DataDeNascimento { get; private set; }

        public string Logradouro { get; private set; }

        public string Complemento { get; private set; }

        public string Numero { get; private set; }

        public string Cep { get; private set; }

        public string Municipio { get; private set; }

        public string Bairro { get; private set; }

        public string Cidade { get; private set; }

        public string Estado { get; private set; }

        public UsuarioRegistradoIntegrationEvent(Guid usuarioId, string matricula, string nome, string cpf, string email, string rgNumero, 
            string rgOrgaoEmissor, string rgPaisEmissor, DateTime? rgDataDeEmissao, string telefone, string celular, 
            string foto, string nomeOriginal, bool inativo, int sexo, bool pne, int tipoUsuario, int tipoSanguineo, string observacao, string orientacoesMedicas, 
            int religiao, string doenca, string alergia, DateTime dataDeNascimento, string logradouro, string complemento, string numero, string cep, 
            string municipio, string bairro, string cidade, string estado)
        {
            AggregateId = usuarioId;
            Matricula = matricula;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            RgNumero = rgNumero;
            RgOrgaoEmissor = rgOrgaoEmissor;
            RgPaisEmissor = rgPaisEmissor;
            RgDataDeEmissao = rgDataDeEmissao;
            Telefone = telefone;
            Celular = celular;
            Foto = foto;
            NomeOriginal = nomeOriginal;
            Inativo = inativo;
            Sexo = sexo;
            Pne = pne;
            TipoUsuario = tipoUsuario;
            TipoSanguineo = tipoSanguineo;
            Observacao = observacao;
            OrientacoesMedicas = orientacoesMedicas;
            Religiao = religiao;
            Doenca = doenca;
            Alergia = alergia;
            DataDeNascimento = dataDeNascimento;
            Logradouro = logradouro;
            Complemento = complemento;
            Numero = numero;
            Cep = cep;
            Municipio = municipio;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}