namespace ideacode.core.ValueObjects;

public class Intervalo
{
    public DateTime Inicio { get; private set; }
    public DateTime Fim { get; private set; }
    public int Limite { get; private set; }

    public string InicioFormatada => Inicio.ToString("dd/MM/yyyy");

    public string FimFormatada => Fim.ToString("dd/MM/yyyy");

    protected Intervalo()
    {
    }

    public Intervalo(DateTime inicio)
    {
        Inicio = inicio;
        Fim = inicio;
    }

    public Intervalo(DateTime? inicio, DateTime? fim, int limite = 20)
    {
        Fim = fim ?? DateTime.Now.Date;
        Limite = limite;
        Inicio = inicio ?? Fim.AddDays(-Limite);
    }

    public void AtribuirDataDeInicio(DateTime dataInicio) => Inicio = dataInicio;
    public void AtribuirDataDeFim(DateTime dataFim) => Fim = dataFim;

    public bool EstaValido()
    {
        return Fim.Date >= Inicio.Date;
    }

    public bool EstaEntreInicioEhFim(DateTime data)
    {
        return data.Date >= Inicio.Date &&
               data.Date <= Fim.Date;
    }

    public bool EstaDentroDoLimite()
    {
        return Fim.Date.Subtract(Inicio.Date).TotalDays <= Limite;
    }

    public bool InicioTerminoIguais()
    {
        return Inicio.Date == Fim.Date;
    }

    public bool FimEstaMaiorInicio() => Fim.Date > Inicio.Date;

    public bool SobrePosto(Intervalo intervalo)
    {
        return EstaEntreInicioEhFim(intervalo.Inicio) || EstaEntreInicioEhFim(intervalo.Fim);
    }

    /// <summary>
    /// Retorna o total de dias entre o intervalo
    /// </summary>
    /// <returns></returns>
    public int Dias()
    {
        return (Fim - Inicio).Days;
    }
}