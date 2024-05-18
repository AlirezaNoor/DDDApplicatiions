using DDDApplication.Domian.Core.Base;

namespace DDDApplication.Domian.Core.Customer;

public class AdderssInfo : Entity<Guid>
{
    public CustomerId CustomerId { get; private set; }
    public string Title { get; private set; }
    public string Address { get; private set; }
    public string postalcode { get; private set; }


    public static AdderssInfo CreatenewAddress(CustomerId customerId, string title, string address, string postalcode)
    {
        return new AdderssInfo(customerId, title, address, postalcode);
    }


    #region Constructur

    protected AdderssInfo()
    {
    }

    public AdderssInfo(CustomerId customerId, string title, string address, string postalcode)
    {
        CustomerId = customerId;
        Title = title;
        Address = address;
        this.postalcode = postalcode;
    }

    #endregion
}