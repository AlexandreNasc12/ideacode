using System.Net;
using System.Net.Mail;

namespace ideacode.core.EmailConfiguracao;

public abstract class SmtpService : SmtpClient
{
    public readonly MailMessage _Email;

    public abstract string SubstituirValores();

    public abstract Task EnviarEmail();

    public SmtpService(AutenticacaoSmtpServer autenticacao)
            :base (autenticacao.Servidor, autenticacao.Porta)
    {
        _Email = new MailMessage();
        Credentials = new NetworkCredential(autenticacao.Usuario, autenticacao.Senha);
        EnableSsl = true;
    }

    public void ConfigurarEnvio(EmailConfig configuracao)
    {
        _Email.From = new MailAddress(configuracao.EnviadoPor, configuracao.Titulo);
        _Email.Subject = configuracao.Assunto;
        _Email.IsBodyHtml = true;
        _Email.Body = configuracao.Conteudo;
    }
}