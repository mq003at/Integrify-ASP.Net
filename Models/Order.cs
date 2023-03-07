namespace dotnet.Models;

public class Order 
{
    public int CustomerID {get; set;}
    public ICollection<OrderItem>? Items {get; set;}

}

public class OrderItem
{
    public int ProductID {get; set;}
    public int Amount {get; set;}
    public double ProductPrice {get; set;}
}