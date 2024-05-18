namespace DDDApplication.Domian.Core.Sherad;

public record class CustomerAddressInfo
{
    public string Title { get; init; }
    public string Address { get; init; }
    public string postalcode { get; init; }
}