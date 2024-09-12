using System.ComponentModel;
using System.Text;

namespace ideacode.core.Utils;

public static class StringUtils
{
    public static string ApenasNumeros(this string input)
    {
        return !string.IsNullOrEmpty(input) ? new string(input.Where(char.IsDigit).ToArray()) : "";
    }

    public static bool EhNumero(this string input)
    {
        var numeros = input.ApenasNumeros();
        return numeros.All(char.IsDigit);
    }

    public static string RemoveAcentos(this string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return texto;

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] > 255)
                sb.Append(texto[i]);
            else
                sb.Append(s_Diacritics[texto[i]]);
        }

        return sb.ToString();
    }

    public static string ToCamelCase(this string str) =>
        string.IsNullOrEmpty(str) || str.Length < 2
            ? str
            : char.ToLowerInvariant(str[0]) + str.Substring(1);


    private static readonly char[] s_Diacritics = GetDiacritics();

    private static char[] GetDiacritics()
    {
        char[] accents = new char[256];

        for (int i = 0; i < 256; i++)
            accents[i] = (char)i;

        accents[(byte)'á'] =
            accents[(byte)'à'] = accents[(byte)'ã'] = accents[(byte)'â'] = accents[(byte)'ä'] = 'a';
        accents[(byte)'Á'] =
            accents[(byte)'À'] = accents[(byte)'Ã'] = accents[(byte)'Â'] = accents[(byte)'Ä'] = 'A';

        accents[(byte)'é'] = accents[(byte)'è'] = accents[(byte)'ê'] = accents[(byte)'ë'] = 'e';
        accents[(byte)'É'] = accents[(byte)'È'] = accents[(byte)'Ê'] = accents[(byte)'Ë'] = 'E';

        accents[(byte)'í'] = accents[(byte)'ì'] = accents[(byte)'î'] = accents[(byte)'ï'] = 'i';
        accents[(byte)'Í'] = accents[(byte)'Ì'] = accents[(byte)'Î'] = accents[(byte)'Ï'] = 'I';

        accents[(byte)'ó'] =
            accents[(byte)'ò'] = accents[(byte)'ô'] = accents[(byte)'õ'] = accents[(byte)'ö'] = 'o';
        accents[(byte)'Ó'] =
            accents[(byte)'Ò'] = accents[(byte)'Ô'] = accents[(byte)'Õ'] = accents[(byte)'Ö'] = 'O';

        accents[(byte)'ú'] = accents[(byte)'ù'] = accents[(byte)'û'] = accents[(byte)'ü'] = 'u';
        accents[(byte)'Ú'] = accents[(byte)'Ù'] = accents[(byte)'Û'] = accents[(byte)'Ü'] = 'U';

        accents[(byte)'ç'] = 'c';
        accents[(byte)'Ç'] = 'C';

        accents[(byte)'ñ'] = 'n';
        accents[(byte)'Ñ'] = 'N';

        accents[(byte)'ÿ'] = accents[(byte)'ý'] = 'y';
        accents[(byte)'Ý'] = 'Y';

        return accents;
    }

    public static string AlfanumericoAleatorio(int tamanho)
    {
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        var result = new string(
            Enumerable.Repeat(chars, tamanho)
                .Select(s => s[random.Next(s.Length)])
                .ToArray());
        return result;
    }

    public static string CapitalizarNome(this string nome)
    {
        string[] excecoes = new string[] { "e", "de", "da", "das", "do", "dos" };
        var palavras = new Queue<string>();
        foreach (var palavra in nome.Split(' '))
        {
            if (!string.IsNullOrEmpty(palavra))
            {
                var emMinusculo = palavra.ToLower();
                var letras = emMinusculo.ToCharArray();
                if (!excecoes.Contains(emMinusculo)) letras[0] = char.ToUpper(letras[0]);
                palavras.Enqueue(new string(letras));
            }
        }

        return string.Join(" ", palavras);
    }

    public static string TrataEspacos(this string nome)
    {
        var palavras = new Queue<string>();

        foreach (var palavra in nome.Split(' '))
        {
            if (string.IsNullOrEmpty(palavra)) continue;

            var letras = palavra.Trim().ToCharArray();

            palavras.Enqueue(new string(letras));
        }

        return string.Join(" ", palavras);
    }

    public static string TrataCaracteresEspeciais(this string nome)
    {
        return nome.Replace("_", "")
            .Replace("#", "")
            .Replace("$", "")
            .Replace(".", "")
            .Replace("-", "")
            .Replace(",", "")
            .Replace("*", "")
            .Replace("%", "")
            .Replace("@", "")
            .Replace("(", "")
            .Replace(")", "")
            .Replace("=", "")
            .Replace("|", "")
            .Replace("\\", "")
            .Replace("/", "")
            .Replace("?", "")
            .Replace(";", "")
            .Replace(":", "")
            .Replace("&", "")
            .Replace("+", "");
    }

    public static DateTime? ConverterParaData(this string dataFormatoAmericano)
    {
        if (string.IsNullOrWhiteSpace(dataFormatoAmericano)) return null;

        if (!dataFormatoAmericano.Contains('-')) return null;

        var arrayDeData = dataFormatoAmericano.Split('-');

        try
        {
            return new DateTime(Convert.ToInt32(arrayDeData[0]),
                Convert.ToInt32(arrayDeData[1]), Convert.ToInt32(arrayDeData[2]));
        }
        catch
        {
            return null;
        }
    }

    public static DateTime? ConverterParaDataBarras(this string dataFormatoBrasil)
    {
        if (string.IsNullOrWhiteSpace(dataFormatoBrasil)) return null;

        if (!dataFormatoBrasil.Contains('/')) return null;

        var arrayDeData = dataFormatoBrasil.Split('/');

        try
        {
            return new DateTime(Convert.ToInt32(arrayDeData[2]),
                Convert.ToInt32(arrayDeData[1]), Convert.ToInt32(arrayDeData[0]));
        }
        catch
        {
            return null;
        }
    }

    public static string FormatarDataDeLeituraParaExibicao(this string dataPadraoAmericano)
    {
        if (!dataPadraoAmericano.Contains('-')) return null;

        var arrayDeData = dataPadraoAmericano.Split('-');

        return $"{arrayDeData[2]}/{arrayDeData[1]}/{arrayDeData[0]}";
    }

    public static DateTime ProximoDiaUtil(this DateTime dataDeHoje, int quantidadeDeDias)
    {
        if (quantidadeDeDias < 0)
        {
            throw new ArgumentException("Quantidade de dias não pode ser negativo", "Dias");
        }

        if (quantidadeDeDias == 0) return dataDeHoje;

        if (dataDeHoje.DayOfWeek == DayOfWeek.Saturday)
        {
            dataDeHoje = dataDeHoje.AddDays(2);
        }
        else if (dataDeHoje.DayOfWeek == DayOfWeek.Sunday)
        {
            dataDeHoje = dataDeHoje.AddDays(1);
        }

        var contador = 0;

        while (contador < quantidadeDeDias)
        {
            if (dataDeHoje.DayOfWeek == DayOfWeek.Saturday)
            {
                dataDeHoje = dataDeHoje.AddDays(2);
                contador++;
                continue;
            }
            else if (dataDeHoje.DayOfWeek == DayOfWeek.Sunday)
            {
                dataDeHoje = dataDeHoje.AddDays(1);
                contador++;
                continue;
            }

            dataDeHoje = dataDeHoje.AddDays(1);
            contador++;
        }

        return dataDeHoje;
    }

    public static string ObterDescricao(this Enum element)
    {
        var elementInfo = element.GetType().GetField(element.ToString());

        var attributes = (DescriptionAttribute[])elementInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

        if (attributes.Length == 0) return element.ToString();

        return attributes[0].Description;
    }
}