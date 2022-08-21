namespace LibraryToBeTested;

public class UnitOfWork : IUnitOfWork
{
    public Task CommitAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}