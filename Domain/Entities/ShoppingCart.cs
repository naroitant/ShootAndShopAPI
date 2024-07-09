namespace Domain.Entities;

public class ShoppingCart(List<Product> products) : Set(products) { }
