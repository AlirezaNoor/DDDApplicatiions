using MediatR;

namespace DDDApplication.Domian.Core.Base;

public interface IDoaminEvent:INotification
{
    
}

public abstract record class Message
{
    public Guid AgrigateId { get; set; }
    public string MeesageType { get; set; }

    protected Message()
    {
        MeesageType = GetType().FullName;
    }
}

public abstract record class DoaminEvent:Message,IDoaminEvent
{
    public DateTime CreateAt { get; set; }

    public DoaminEvent()
    {
        CreateAt=DateTime.Now;
    }
}