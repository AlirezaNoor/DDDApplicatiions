using DDDApplication.Domian.Core.Base;

namespace DDDApplication.Domian.Core.Customer;

public sealed class CustomerId:StronglyTypeid<CustomerId>
{
    public CustomerId(Guid value) : base(value)
    {
    }
}