using DDDApplication.Domian.Core.Customer;
using DDDApplication.Domian.Core.Sherad;

namespace DDDApplication.Domian.Core.Order;

public interface IOrdertManegar
{
    Task Registratio(CustomerId customerId, string orderCode, OrderStatus orderStatus, string CustomerAddress,
        string postalcOrderCode, string Phone, List<OrderItemData> datas);

    Task CancelOrder(OderId orderId, CustomerId customerId);
    Task CancelOrderWithAdmin(OderId orderId, CustomerId customerId);
}