using DDDApplication.Domian.Core.Base;

namespace DDDApplication.Domian.Core.Order;

public sealed class OderId:StronglyTypeid<OderId>
{
    public OderId(Guid value) : base(value)
    {
    }
}