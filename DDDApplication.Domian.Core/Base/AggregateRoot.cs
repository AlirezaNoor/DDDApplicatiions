namespace DDDApplication.Domian.Core.Base;

public abstract class AggregateRoot<Tkey>:Entity<Tkey>,IAggregateRoot
{
    public IReadOnlyCollection<IDoaminEvent> EventDoamins => _domainEvents?.AsReadOnly();

    protected void AddDomainEvent(IDoaminEvent domainEvent)
    {
        _domainEvents = _domainEvents ?? new List<IDoaminEvent>();
        _domainEvents.Add(domainEvent);
        //publish
    }
    public void ClearDomainEvent()
    {
        _domainEvents.Clear();
    }
  

    private List<IDoaminEvent> _domainEvents;
}