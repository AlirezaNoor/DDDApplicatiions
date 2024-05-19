using DDDApplication.Domian.Core.Catalogs.Categories.Feature.Events;
using MediatR;

namespace DDDApplication.Domian.Core.Customer.Event;

public class AddFeaturtSendNotification : INotificationHandler<SendToCustomerEvent>
{
    public Task Handle(SendToCustomerEvent notification, CancellationToken cancellationToken)
    {
        return Task.FromResult(notification);
    }
}