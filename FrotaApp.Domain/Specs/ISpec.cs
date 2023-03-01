namespace FrotaApp.Domain.Spec
{
    public interface ISpec<in T> where T : class
    {
        bool IsSatifiedBy(T candidato);
    }
}