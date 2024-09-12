namespace ideacode.core.EmailConfiguracao;

public class AutenticacaoSmtpServer
{
    public string Servidor { get; private set; }

    public int Porta { get; private set; }

    public string Usuario { get; private set; }

    public string Senha { get; private set; }

    public AutenticacaoSmtpServer(string servidor, int porta, string usuario, string senha)
    {
        Servidor = servidor;
        Porta = porta;
        Usuario = usuario;
        Senha = senha;
    }
}
