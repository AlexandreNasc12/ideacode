namespace ideacode.core.Data
{
    public interface IUnitOfWorks
    {
        Task<bool> Commit();
    }
}