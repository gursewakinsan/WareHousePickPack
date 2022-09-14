using System;
using System.Collections.Generic;
using System.Text;

namespace WareHousePickPack.Models
{
    public class PickPackJsonModel
    {
        public List<Warehouse> WarehouseList { get; set; }
        public Customer Customer { get; set; }
        public List<Order> Order { get; set; }
    }

    public class Warehouse
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Inventory
    {
        public string ItemName { get; set; }
        public string ItemQty { get; set; }
        public string ItemPrice { get; set; }
        public string IsDeleted { get; set; }
        public string PickOrPack { get; set; }
    }

    public class Order
    {
        public string Id { get; set; }
        public string PickOrPack { get; set; }
        public Warehouse Warehouse { get; set; }
        public List<Inventory> Inventory { get; set; }
        public Customer Customer { get; set; }
    }

    
}




public class Warehouse
{
    private String code;
    private String name;
    private Address address;
    public String getCode()
    {
        return code;
    }
    public void setCode(String code)
    {
        this.code = code;
    }
    public String getName()
    {
        return name;
    }
    public void setName(String name)
    {
        this.name = name;
    }
    public Address getAddress()
    {
        return address;
    }
    public void setAddress(Address address)
    {
        this.address = address;
    }
}

public class Address
{
    private String firstName;
    private String lastName;
    private String addressLineOne;
    private String addressLineTwo;
    private String city;
    private String state;
    private String zip;
    private String country;
    public String getFirstName()
    {
        return firstName;
    }
    public String getLastName()
    {
        return lastName;
    }
    public String getAddressLineOne()
    {
        return addressLineOne;
    }
    public String getAddressLineTwo()
    {
        return addressLineTwo;
    }
    public String getCity()
    {
        return city;
    }
    public String getState()
    {
        return state;
    }
    public String getZip()
    {
        return zip;
    }
    public String getCountry()
    {
        return country;
    }
    public void getFirstName(String firstName)
    {
        this.firstName = firstName;
    }
    public void getLastName(String lastName)
    {
        this.lastName = lastName;
    }
    public void getAddressLineOne(String addressLineOne)
    {
        this.addressLineOne = addressLineOne;
    }
    public void getAddressLineTwo(String addressLineTwo)
    {
        this.addressLineTwo = addressLineTwo;
    }
    public void getCity(String city)
    {
        this.city = city;
    }
    public void getState(String state)
    {
        this.state = state;
    }
    public void getZip(String zip)
    {
        this.zip = zip;
    }
    public void setCountry(String country)
    {
        this.country = country;
    }
}