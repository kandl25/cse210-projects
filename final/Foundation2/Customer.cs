using System;
using System.Collections.Generic;

public class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }

    public string GetFullAddress()
    {
        return $"{Name}\n{Address.GetFullAddress()}";
    }
}