using System.Net.Mail;

namespace ideacode.core.EmailConfiguracao
{
    public abstract class ServicoDeEmail : SmtpAmazonService
    {
        public readonly MailMessage _Email;

        public abstract string SubstituirValores();

        public abstract Task EnviarEmail();

        public void ConstruirEmail(string Assunto, string ConteudoDoEmail, string enviadoPor, string titulo)
        {
            _Email.From = new MailAddress(enviadoPor, titulo);
            _Email.Subject = Assunto;
            _Email.IsBodyHtml = true;
            _Email.Body = ConteudoDoEmail;
        }

        public ServicoDeEmail() => _Email = new MailMessage();
    }
}