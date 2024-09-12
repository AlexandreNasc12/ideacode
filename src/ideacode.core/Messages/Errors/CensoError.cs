namespace ideacode.core.Messages.Errors
{
    public class CensoErro : Error
    {
        public string codigo { get; set; }
        public string campo { get; set; }

        public CensoErro(string codigo, string campo, string descricao)
        {
            this.codigo = codigo;
            this.campo = campo;
            this.Description = descricao;
        }
        //$"{codigo} - {campo}: {erro}"
    }
}

