namespace Domain.ValueObjects;

public class Address
{
    private string AddressLine1 { get; }
    private string AddressLine2 { get; }
    private string PostCode { get; }
    private string City { get; }
    
    private Address() { }
    
    public Address(string addressLine1, string addressLine2, string postCode, string city)
    {
        AddressLine1 = addressLine1 ?? throw new ArgumentNullException(nameof(addressLine1));
        AddressLine2 = addressLine2;
        PostCode = postCode ?? throw new ArgumentNullException(nameof(postCode));
        City = city ?? throw new ArgumentNullException(nameof(city));
    }
    
    public override bool Equals(object obj)
    {
        return obj is Address address &&
               AddressLine1 == address.AddressLine1 &&
               AddressLine2 == address.AddressLine2 &&
               PostCode == address.PostCode &&
               City == address.City;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(AddressLine1, AddressLine2, PostCode, City);
    }
    
    public override string ToString()
    {
        return $"{AddressLine1}, {AddressLine2}, {City}, {PostCode}";
    }
}