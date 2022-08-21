namespace LibraryToBeTested;

public interface IUnitOfWork
{
    Task CommitAsync(CancellationToken cancellationToken);
}