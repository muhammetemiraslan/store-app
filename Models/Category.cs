namespace dotnet_store.Models;

// entity
public class Category
{
    public int Id { get; set; }
    public string CategoryName { get; set; } = null!;
    public string Url { get; set; } = null!;

    public List<Product> Products { get; set; } = new();
}