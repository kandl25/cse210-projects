using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public float CalculateTotalCost()
    {
        float totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in products)
        {
            packingLabel.AppendLine($"Product: {product.Name}, ID: {product.ProductId}");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return customer.GetFullAddress();
    }
}