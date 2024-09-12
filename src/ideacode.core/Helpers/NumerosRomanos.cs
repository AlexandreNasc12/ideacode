using System.Collections;
using Microsoft.VisualBasic.CompilerServices;

namespace ideacode.core.Helpers
{
    public class NumerosRomanos
    {
        public int ConverterNumeroRomanoParaInteiro(string numeroRomano)
        {
            numeroRomano = numeroRomano.ToUpper().Trim();

            int ptr = 0;
            var valores = new ArrayList();
            int digitoMaximo = 1000;
            while (ptr < numeroRomano.Length)
            {
                // valor base do digito
                char numeral = numeroRomano[ptr];
                int digito = Conversions.ToInteger(Enum.Parse(typeof(DigitosRomanos), numeral.ToString()));

                if (ptr < numeroRomano.Length - 1)
                {
                    char proximoNumeral = numeroRomano[ptr + 1];
                    var proximoDigito = Conversions.ToInteger(Enum.Parse(typeof(DigitosRomanos), proximoNumeral.ToString()));
                    if (proximoDigito > digito)
                    {
                        if ("IXC".IndexOf(numeral) == -1 || proximoDigito > digito * 10 || numeroRomano.Split(numeral).Length > 3)
                        {
                            throw new ArgumentException("Rule 3");
                        }

                        digitoMaximo = digito - 1;
                        digito = proximoDigito - digito;
                        ptr += 1;
                    }
                }

                valores.Add(digito);
                ptr += 1;
            }

            // Numerais maiores devem ser colocados à esquerda dos números menores para 
            // continuar a combinação aditiva. Assim VI é igual a seis e MDCLXI é 1.661.
            int total = 0;
            foreach (int digito in valores)
                total += digito;
            return total;
        }

        private enum DigitosRomanos
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }
    }
}