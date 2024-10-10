class Product
{
    public string name;
    public string productID;
    private double price;
    private int quantity;

    public Product(string _name, string _productID, double _price, int _quantity)
    {
        name = _name;
        productID = _productID;
        price = _price;
        quantity = _quantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductID()
    {
        return productID;
    }
}