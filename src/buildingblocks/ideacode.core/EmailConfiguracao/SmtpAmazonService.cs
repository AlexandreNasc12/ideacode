using System.Net;
using System.Net.Mail;

namespace ideacode.core.EmailConfiguracao
{
    public class SmtpAmazonService : SmtpClient
    {
        public SmtpAmazonService()
            : base("email-smtp.us-west-2.amazonaws.com", 587)
        {
            Credentials = new NetworkCredential("AKIASOWCVT3OMEKPJJXI", "BBTEJTSgReKNV4v7TzwWnWpTcJ6Thqa4jwtdG7YtfJQY");
            EnableSsl = true;
        }

        public SmtpAmazonService(string smtp)
            : base(smtp, 587)
        {
            Credentials = new NetworkCredential("AKIASOWCVT3OMEKPJJXI", "BBTEJTSgReKNV4v7TzwWnWpTcJ6Thqa4jwtdG7YtfJQY");
            EnableSsl = true;
        }
    }
}