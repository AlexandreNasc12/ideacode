namespace ideacode.core.Helpers;

public static class ManipularListas
{
    public static IEnumerable<T> ObterDiferenca<T>(this IEnumerable<T> lista1, IEnumerable<T> lista2)
    {
        var hash1 = new HashSet<T>(lista1);
        var hash2 = new HashSet<T>(lista2);
        hash1.SymmetricExceptWith(hash2);
        return hash1;
    }
}