class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer _customer)
    {
        customer = _customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }
        return total += customer.LivesInUSA() ? 5 : 35;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductID()})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetShippingLabel()}";
    }
}