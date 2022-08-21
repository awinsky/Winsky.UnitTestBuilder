namespace LibraryToBeTested;

public interface IRepository<in T>
{
    void Add(T entity);
    void Update(T entity);
}