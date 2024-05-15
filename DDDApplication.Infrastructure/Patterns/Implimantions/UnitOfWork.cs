using DDDApplication.Infrastructure.Patterns.interfaces;
using Microsoft.EntityFrameworkCore;

namespace DDDApplication.Infrastructure.Patterns.Implimantions;

public class UnitOfWork : IUnitOfWorks
{
    private readonly DbContext _dbContext;

    public UnitOfWork(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }

    public async Task SaveChanges()
    {
        _dbContext.SaveChangesAsync();
    }
}