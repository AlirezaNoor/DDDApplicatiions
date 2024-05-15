namespace DDDApplication.Infrastructure.Patterns.interfaces;

public interface IUnitOfWorks:IDisposable
{
    Task SaveChanges();
}