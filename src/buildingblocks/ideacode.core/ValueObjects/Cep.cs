using System.Text.RegularExpressions;

namespace ideacode.core.ValueObjects
{
    public class Cep
    {
        public string Numero { get; private set; }

        private readonly string _NumeroFormatado;
        protected Cep() { }

        public Cep(string numeroDoCep)
        {
            if (string.IsNullOrEmpty(numeroDoCep)) return;

            _NumeroFormatado = numeroDoCep;
            Numero = Numero = numeroDoCep.Trim().Replace("-", "");
        }

        public bool EstaValido()
        {
            if (string.IsNullOrWhiteSpace(_NumeroFormatado)) return false;

            Regex regex = new Regex(@"^\d{5}-\d{3}$");

            Match match = regex.Match(_NumeroFormatado);

            return match.Success;
        }
    }
}