namespace DDDApplication.Domian.Core.Base;

public interface IAggregateRoot
{
    IReadOnlyCollection<IDoaminEvent> EventDoamins { get; }
    void ClearDomainEvent();
}