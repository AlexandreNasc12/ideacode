namespace ideacode.core.Helpers
{
    [System.AttributeUsage(System.AttributeTargets.Property,AllowMultiple = true)]
    public class ExcelIgnoreAttribute : Attribute
    {
        public bool Ignore { get; set; }
        public ExcelIgnoreAttribute()
        {
            this.Ignore = true;
        }
    }
}
