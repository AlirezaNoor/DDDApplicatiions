namespace DDDApplication.Domian.Core.Base;

public abstract class AggregateRoot<Tkey>:Entity<Tkey>,IAggregateRoot
{
    public IReadOnlyCollection<IDoaminEvent> EventDoamins => _doaminEvents?.AsReadOnly();

    protected void AddDomainEvent(IDoaminEvent doaminEvent)
    {
        _doaminEvents = _doaminEvents ?? new List<IDoaminEvent>();
        _doaminEvents.Add(doaminEvent);
    }
    public void ClearDomainEvent()
    {
     _doaminEvents.Clear();
    }
  

    private List<IDoaminEvent> _doaminEvents;
}