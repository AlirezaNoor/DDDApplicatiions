using DDDApplication.Domian.Core.Base;
using DDDApplication.Domian.Core.Customer;
using DDDApplication.Domian.Core.Sherad;

namespace DDDApplication.Domian.Core.Order;

public class Order : AggregateRoot<OderId>
{
    public CustomerId CustomerId { get; private set; }
    public DateTime CreateDate { get; private set; }
    public string OrderCode { get; private set; }
    public OrderStatus OrderStatus { get; private set; }
    public string OrderStatusRemark { get; private set; }
    public Address Address { get; set; }
    public IReadOnlyList<orderItem> OrderItems => _orderitem;
    private List<orderItem> _orderitem = new List<orderItem>();

    private void BuildOrderItem(List<OrderItemData> datas)
    {
        foreach (var data in datas)
        {
            var result = orderItem.CreateOrderItem(data.ProductId, Id, data.ItemCount, data.Price);
            _orderitem.Add(result);
        }
    }

    public static Order CreateOrder(CustomerId customerId, string orderCode, OrderStatus orderStatus,
        string CustomerAddress, string postalcOrderCode, string Phone, List<OrderItemData> datas)
    {
        return new Order(customerId, orderCode, orderStatus,
            CustomerAddress, postalcOrderCode, Phone, datas);
    }
    internal static void Accept(OderId orderId)
    {
        //?? Aggregate or DomainService
    }

    internal static void Reject(OderId orderId, string rejectMessage)
    {
        //?? Aggregate or DomainService
    }
    #region MyRegion

    private Order()
    {
    }

    private Order(CustomerId customerId, string orderCode, OrderStatus orderStatus, string CustomerAddress,
        string postalcOrderCode, string Phone, List<OrderItemData> datas)
    {
        CustomerId = customerId;
        CreateDate = DateTime.Now;
        OrderCode = orderCode;
        OrderStatus = OrderStatus.Registerd;
        Address = Address.CreAddress(CustomerAddress, postalcOrderCode, Phone);
        BuildOrderItem(datas);
    }

    #endregion
}