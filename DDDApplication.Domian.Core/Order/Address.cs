using DDDApplication.Domian.Core.Base;

namespace DDDApplication.Domian.Core.Order;

public class Address : ValueObject<Address>
{
    public string CustomerAddress { get; private set; }
    public string PostalCode { get; private set; }
    public string Phone { get; private set; }

    protected override bool Equalcore(Address other)
    {
        throw new NotImplementedException();
    }

    protected override int GetHachCodeCore()
    {
        throw new NotImplementedException();
    }

    public Address CreAddress(string customerAddress, string postalCode, string phone)
    {
        return new Address(customerAddress, postalCode, phone);
    }

    #region MyRegion

    private Address()
    {
    }

    private Address(string customerAddress, string postalCode, string phone)
    {
        CustomerAddress = customerAddress;
        PostalCode = postalCode;
        Phone = phone;
    }

    #endregion
}