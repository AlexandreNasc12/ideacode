namespace ideacode.core.ValueObjects
{
    public class Endereco
    {
        public const int LogradouroMaximo = 200, ComplementoMaximo = 200, NumeroMaximo = 50, CepNumero = 10, BairroMaximo = 200, CidadeMaximo = 200, EstadoMaximo = 100, MunicipioMaximo = 200;

        public string Logradouro { get; private set; }

        public string Complemento { get; private set; }

        public string Numero { get; private set; }

        public string Cep { get; private set; }

        public string Bairro { get; private set; }

        public string Cidade { get; private set; }

        public string Estado { get; private set; }

        public string Municipio { get; private set; }

        public string Latitude { get; private set; }

        public string Longitude { get; private set; }


        public string BairroTratamentoBarra() => Bairro.Replace("/", "-");

        public string ObterCepFormatado
        {
            get
            {
                int Contador = 0;
                string CepComMascara = "";

                if (string.IsNullOrWhiteSpace(Cep)) return String.Empty;

                foreach (var digito in Cep)
                {
                    if (Contador == 5)
                        CepComMascara += "-";

                    CepComMascara += digito;

                    Contador++;
                }

                return CepComMascara;
            }
        }

        protected Endereco() { }

        public Endereco(string Logradouro, string Complemento, string Numero, string CepDoEndereco, string Bairro,
            string Cidade, string Estado, string Municipio, string Latitude = null, string Longitude = null)
        {
            setLogradouro(Logradouro);
            setComplemento(Complemento);
            setNumero(Numero);
            setBairro(Bairro);
            setCidade(Cidade);
            setEstado(Estado);
            setCep(CepDoEndereco);
            setMunicipio(Municipio);
            AtribuirLatitude(Latitude);
            AtribuirLongitude(Longitude);
        }


        public void setLogradouro(string logradouroStr)
        {
            if (!string.IsNullOrEmpty(logradouroStr))
                Logradouro = logradouroStr.Trim().ToUpper();
        }

        public void setMunicipio(string municipio)
        {
            if (!string.IsNullOrEmpty(municipio))
                this.Municipio = municipio.Trim().ToUpper();
        }
         

        public void setComplemento(string complementoStr)
        {
            if (!string.IsNullOrEmpty(complementoStr))
                Complemento = complementoStr.Trim().ToUpper();
            else
                Complemento = "-";
        }

        public void setNumero(string numeroStr)
        {
            if (!string.IsNullOrEmpty(numeroStr))
                Numero = numeroStr.Trim().ToUpper();
            else
                Numero = "S/N";
        }

        public void setCep(string cepStr)
        {
            if (string.IsNullOrWhiteSpace(cepStr)) return;

            var cep = new Cep(cepStr);

            if (!cep.EstaValido()) return;

            Cep = cep.Numero;
        }

        public void setBairro(string bairroStr)
        {
            if (!string.IsNullOrEmpty(bairroStr))
                Bairro = bairroStr.Trim().ToUpper();
            else
                Bairro = "-";
        }

        public void setCidade(string cidadeStr)
        {
            if (!string.IsNullOrEmpty(cidadeStr))
                Cidade = cidadeStr.Trim().ToUpper();
        }

        public void setEstado(string estadoStr)
        {
            if (!string.IsNullOrEmpty(estadoStr))
                Estado = estadoStr.Trim().ToUpper();
        }

        public override string ToString()
        {
            return Logradouro + " " + Complemento + ", " + Numero + ", " + Bairro + " " + Cidade + " " + Estado;
        }

        public void AtribuirLatitude(string latitude) => Latitude = latitude;
        public void AtribuirLongitude(string longitude) => Longitude = longitude;
    }
}