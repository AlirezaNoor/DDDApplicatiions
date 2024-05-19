using DDDApplication.Domian.Core.Base;
using DDDApplication.Infrastructure.Data.Context;
using DDDApplication.Infrastructure.Patterns.interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DDDApplication.Infrastructure.Patterns.Implimantions;

public class UnitOfWork : IUnitOfWorks
{
    private readonly Contexts _dbContext;
    private readonly IMediator _Mediator;

    public UnitOfWork(Contexts dbContext, IMediator mediator)
    {
        _dbContext = dbContext;
        _Mediator = mediator;
    }


    public void Dispose()
    {
        // _dbContext.Dispose();
    }

    public async Task SaveChanges()
    {
        var entites = _dbContext.ChangeTracker.Entries()
            .Where(x => x.Entity is IAggregateRoot c && c.EventDoamins != null).Select(x => x.Entity as IAggregateRoot)
            .ToArray();
        foreach (var entity in entites )
        {
            var Event = entity.EventDoamins.ToArray();
            foreach (var Item in Event)
            {
                await _Mediator.Publish(Item);
            }
            entity.ClearDomainEvent();
        }
        await _dbContext.SaveChangesAsync();
        _dbContext.SaveChanges();
    }
}