using DDDApplication.Infrastructure.Data.Context;
using DDDApplication.Infrastructure.Patterns.interfaces;
using Microsoft.EntityFrameworkCore;

namespace DDDApplication.Infrastructure.Patterns.Implimantions;

public class UnitOfWork : IUnitOfWorks
{
    private readonly Contexts _dbContext;

    public UnitOfWork(Contexts dbContext)
    {
        _dbContext = dbContext;
    }


    public void Dispose()
    {
        // _dbContext.Dispose();
    }

    public async Task SaveChanges()
    {
       await _dbContext.SaveChangesAsync();
        _dbContext.SaveChanges();
    }
}