using DDDApplication.Domian.Core.Catalogs.Products;

namespace DDDApplication.Domian.Core.Order;

public class orderItem
{
    public ProductId produc { get; private set; }
    public OderId order { get; private set; }
    public int Count { get; set; }
    public double Price { get; private set; }

    public static orderItem CreateOrderItem(ProductId produc, OderId order, int count, double price)
    {
        return new orderItem(produc, order, count, price);
    }

    #region MyRegion

    private orderItem()
    {
    }


    public orderItem(ProductId produc, OderId order, int count, double price)
    {
        this.produc = produc;
        this.order = order;
        Count = count;
        Price = price;
    }

    #endregion
}