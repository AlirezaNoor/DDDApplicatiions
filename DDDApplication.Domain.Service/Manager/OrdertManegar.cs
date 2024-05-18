using DDDApplication.Domian.Core.Customer;
using DDDApplication.Domian.Core.Order;
using DDDApplication.Domian.Core.Sherad;

namespace DDDApplication.Domain.Service.Manager;

public class OrdertManegar:IOrdertManegar
{
    public Task Registratio(CustomerId customerId, string orderCode, OrderStatus orderStatus, string CustomerAddress,
        string postalcOrderCode, string Phone, List<OrderItemData> datas)
    {
        throw new NotImplementedException();
    }

    public Task CancelOrder(OderId orderId, CustomerId customerId)
    {
        throw new NotImplementedException();
    }

    public Task CancelOrderWithAdmin(OderId orderId, CustomerId customerId)
    {
        throw new NotImplementedException();
    }
}