namespace ideacode.core.Data
{
    public class PagedResult<T> where T : class
    {
        public IEnumerable<T> List { get; set; }
        public int TotalResults { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string Query { get; set; }
    }
    
    public class PagedResultLegado<T>
    {
        public List<T> list { get; set; }
        public int totalResults { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public string query { get; set; }
    }
}