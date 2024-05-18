using DDDApplication.Domian.Core.Base;
using DDDApplication.Domian.Core.Sherad;

namespace DDDApplication.Domian.Core.Customer;

public class Customer : AggregateRoot<CustomerId>
{
    public string firstName { get; private set; }
    public string LastName { get; private set; }
    public string Moblie { get; set; }
    public string Number { get; set; }
    public IReadOnlyList<AdderssInfo> AdderssInfos => _adderss;
    private List<AdderssInfo> _adderss = new List<AdderssInfo>();


    private void BuilderCustomerAddress(List<CustomerAddressInfo> customerAddressInfo)
    {
        foreach (var addressInfo in customerAddressInfo)
        {
            var resul = AdderssInfo.CreatenewAddress(Id, addressInfo.Title, addressInfo.Address,
                addressInfo.postalcode);
            
            _adderss.Add(resul);
        }
    }


    public static Customer CreateNewCunstractor(string firstName, string lastName, string moblie, string number,
        List<CustomerAddressInfo> customerAddressInfos)
    {
        return new Customer(firstName, lastName, moblie, number, customerAddressInfos);
    }


    #region Constructure

    protected Customer()
    {
    }

    public Customer(string firstName, string lastName, string moblie, string number,
        List<CustomerAddressInfo> customerAddressInfo)
    {
        this.firstName = firstName;
        LastName = lastName;
        Moblie = moblie;
        Number = number;
        BuilderCustomerAddress(customerAddressInfo);
    }

    #endregion
}