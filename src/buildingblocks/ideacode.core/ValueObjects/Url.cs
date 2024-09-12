using System.Net;

namespace ideacode.core.ValueObjects
{
    public class Url
    {
        public const int TamanhoMaximo = 255;

        public string Endereco { get; private set; }

        protected Url() { }

        public Url(string endereco)
        {
            setUrl(endereco);
        }

        public void setUrl(string EnderecoDaUrl)
        {
            if (string.IsNullOrEmpty(EnderecoDaUrl)) return;

            Endereco = WebUtility.UrlDecode(EnderecoDaUrl);
        }

        public bool EstaValido()
        {
            if (string.IsNullOrWhiteSpace(Endereco)) return false;

            if (!Endereco.Contains("http")) return false;

            return true;
        }

        public void ConfigurarUrlDeVideoIncorporada()
        {
            if (string.IsNullOrEmpty(Endereco)) return;
            Endereco = Endereco.Replace("watch?v=", "embed/");
        }

        public string ObterNomeDoLink()
        {
            string[] ArrayUrl = Endereco.Split('/');
            return ArrayUrl[0] + "//" + ArrayUrl[1] + ArrayUrl[2];
        }
    }
}