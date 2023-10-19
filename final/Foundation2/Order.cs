public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double OrderTotal()
    {
        double orderTotal = 0;

        foreach(Product product in _products)
        {
            orderTotal += product.GetPrice();
        }

        orderTotal += _customer.LivesInUSA() ? 5 : 35;
        return orderTotal;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        packingLabel += "PACKING LABEL:\n\n";

        for(int i=0; i<_products.Count; i++)
        {
            packingLabel += $"Name: {_products[i].GetName()}\nID: {_products[i].GetProductId()}";

            if(i < _products.Count - 1)
            {
                packingLabel += "\n\n"; 
            }
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"SHIPPING LABEL:\n\n{_customer.GetName()}\n{_customer.GetAddress()}";
        return shippingLabel;
    }
}