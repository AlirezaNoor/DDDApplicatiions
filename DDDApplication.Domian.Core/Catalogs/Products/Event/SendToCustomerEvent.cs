using DDDApplication.Domian.Core.Base;
using MediatR;

namespace DDDApplication.Domian.Core.Catalogs.Products.Event;

public record class SendToCustomerEvent : DoaminEvent
{
    public ProductId ProductId { get; set; }

    public SendToCustomerEvent(ProductId productId)
    {
        ProductId = productId;
        AgrigateId = productId.GuidValue;
    }
}