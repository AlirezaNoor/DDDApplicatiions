namespace DDDApplication.Infrastructure.Base.Exceptions;

public class InfraException:Exception
{
    public InfraException(string? message) : base(message)
    {
    }
}