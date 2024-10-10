class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string _street, string _city, string _state, string _country)
    {
        street = _street;
        city = _city;
        state = _state;
        country = _country;
    }

    public bool IsInUsa()
    {
        return country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}