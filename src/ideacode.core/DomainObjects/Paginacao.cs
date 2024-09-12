namespace ideacode.core.DomainObjects;

public class Paginacao
{
    private int PageIndex { get; }
    private int PageSize { get; }

    public Paginacao(int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        PageSize = pageSize;
    }

    public int ObterPageSize()
    {
        return PageSize > 0 ? PageSize : 10;
    }

    public int ObterPageIndex()
    {
        var index = PageIndex > 0 ? PageIndex : 1;
        return (index - 1) * ObterPageSize();
    }
}