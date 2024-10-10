class Customer
{
    private string name;
    private Address address;
    public Customer(string _name, Address _address)
    {
        name = _name;
        address = _address;
    }

    public bool LivesInUSA()
    {
        return address.IsInUsa();
    }

    public string GetShippingLabel()
    {
        return $"{name}\n{address.GetFullAddress()}";
    }
}