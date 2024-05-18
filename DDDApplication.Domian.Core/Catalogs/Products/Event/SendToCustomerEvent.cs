using DDDApplication.Domian.Core.Base;
using MediatR;

namespace DDDApplication.Domian.Core.Catalogs.Products.Event;

public class SendToCustomerEvent : IDoaminEvent, INotification
{
    public Guid ProductId { get; private set; }
    public string Title { get; private set; }
    public double Price { get; private set; }

    public SendToCustomerEvent(Guid productId, string title, double price)
    {
        ProductId = productId;
        Title = title;
        Price = price;
    }
}